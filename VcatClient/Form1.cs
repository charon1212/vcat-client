using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VcatClient.RestApi;

namespace VcatClient
{
    public partial class Form1 : Form
    {
        private static readonly string datetimeFormat = "yyyy/MM/dd HH:mm:ss";
        private static readonly string productId = "GMO-BTC";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "更新中...";
            this.Refresh();

            await updateImpl();

            button1.Enabled = true;
            button1.Text = "更新";
        }

        private async Task updateImpl()
        {
            var live = await VcatRestApi.getLive(productId);
            var context = await VcatRestApi.getContext(productId);

            var lastDateTimeStr = (live.timestamp == null) ? "" : GetDateTimeFromUnixTime((long)live.timestamp).ToString(datetimeFormat);

            string text = "";
            text += "■死活情報：\r\n";
            text += "　　最終更新日：" + lastDateTimeStr + "\r\n";
            text += "　　isExecuteMain：" + live.isExecuteMain.ToString() + "\r\n";
            text += "　　isExecuteLast：" + live.isExecuteLast.ToString() + "\r\n";
            text += "■コンテキスト：\r\n";
            text += "　　orderPhase：" + context.orderPhase?.ToString() + "\r\n";
            text += "　　afterSendOrder：" + context.afterSendOrder?.ToString() + "\r\n";
            text += "　　orderId：" + context.orderId?.ToString() + "\r\n";
            text += "　　buyOrderPrice：" + context.buyOrderPrice?.ToString() + "\r\n";
            text += "　　startBuyTimestamp：" + context.startBuyTimestamp?.ToString() + "\r\n";
            text += "　　executePhase：" + context.executePhase?.ToString() + "\r\n";
            text += "　　executeMain：" + context.executeMain?.ToString() + "\r\n";
            text += "　　makeNewOrder：" + context.makeNewOrder?.ToString() + "\r\n";

            textBox1.Text = text;

            reflectContextInfo(context);
        }

        private void reflectContextInfo(Context context)
        {
            if (context.orderPhase != null) cbOrderPhase.Text = context.orderPhase;
            if (context.afterSendOrder != null) cbAfterSendOrder.Text = context.afterSendOrder.ToString();
            if (context.orderId != null) txtOrderId.Text = context.orderId;
            if (context.executePhase != null) cbExecutePhase.Text = context.executePhase.ToString();
            if (context.executeMain != null) cbExecuteMain.Text = context.executeMain.ToString();
            if (context.makeNewOrder != null) cbMakeNewOrder.Text = context.makeNewOrder.ToString();

            if (context.startBuyTimestamp != null)
            {
                var dtStartBuy = GetDateTimeFromUnixTime((long)context.startBuyTimestamp);
                txtStartBuyTimestamp.Text = dtStartBuy.ToString(datetimeFormat);
            }
        }

        private static DateTime GetDateTimeFromUnixTime(long unixTimestamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimestamp / 1000).ToLocalTime();
            return dtDateTime;
        }
        private static long? getUnixTimeFromDateTimeString(string str)
        {
            try
            {
                DateTime dt = DateTime.Parse(str);
                var dto = new DateTimeOffset(dt.Ticks, new TimeSpan(+09, 00, 00));
                return dto.ToUnixTimeMilliseconds();
            }
            catch
            {
                return null;
            }
        }

        private async void btnPatchContext_Click(object sender, EventArgs e)
        {
            txtPatchContextResult.Text = "リクエスト送信中...";
            this.Refresh();

            var obj = makePatchContextJObject();
            if (obj == null) return;
            var result = await VcatRestApi.patchContext(productId, obj);
            txtPatchContextResult.Text = "result: " + result.ToString();
        }

        private JObject makePatchContextJObject()
        {
            long? startBuyTimestamp = null;
            if (txtStartBuyTimestamp.Text != "")
            {
                long? unixTimestamp = getUnixTimeFromDateTimeString(txtStartBuyTimestamp.Text);
                if (unixTimestamp == null)
                {
                    MessageBox.Show("starttimestampの書式が合いません。");
                    return null;
                }
            }

            var rootJsonObj = new JObject();

            if (cbOrderPhase.Text == "undefined") rootJsonObj.Add("orderPhase", new JValue("undefined"));
            if (cbOrderPhase.Text == "Buy") rootJsonObj.Add("orderPhase", new JValue("Buy"));
            if (cbOrderPhase.Text == "Sell") rootJsonObj.Add("orderPhase", new JValue("Sell"));
            if (cbOrderPhase.Text == "StopLoss") rootJsonObj.Add("orderPhase", new JValue("StopLoss"));
            if (cbOrderPhase.Text == "Wait") rootJsonObj.Add("orderPhase", new JValue("Wait"));

            addJObjectBoolAttr(rootJsonObj, "afterSendOrder", cbAfterSendOrder.Text);
            if (txtOrderId.Text != "") rootJsonObj.Add("orderId", new JValue(txtOrderId.Text));
            if (startBuyTimestamp != null) rootJsonObj.Add("startBuyTimestamp", new JValue(startBuyTimestamp));
            addJObjectBoolAttr(rootJsonObj, "executePhase", cbExecutePhase.Text);
            addJObjectBoolAttr(rootJsonObj, "executeMain", cbExecuteMain.Text);
            addJObjectBoolAttr(rootJsonObj, "makeNewOrder", cbMakeNewOrder.Text);

            return rootJsonObj;

        }

        private void addJObjectBoolAttr(JObject obj, string attributeName, string value)
        {
            if (value == "undefined") obj.Add(attributeName, new JValue("undefined"));
            if (value == "true") obj.Add(attributeName, new JValue(true));
            if (value == "false") obj.Add(attributeName, new JValue(false));
        }

        private void btnNowStartBuyTimestamp_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txtStartBuyTimestamp.Text = DateTime.Now.ToString(datetimeFormat);
        }

    }
}
