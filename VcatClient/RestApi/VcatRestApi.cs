using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace VcatClient.RestApi
{
    public class Live
    {
        public long? timestamp;
        public bool? isExecuteMain;
        public bool? isExecuteLast;
    }
    public class Context
    {
        public string orderPhase;
        public bool? afterSendOrder;
        public string orderId;
        public double? buyOrderPrice;
        public long? startBuyTimestamp;
        public bool? executePhase;
        public bool? executeMain;
        public bool? makeNewOrder;
    }
    public static class VcatRestApi
    {
        public static async Task<Live> getLive(string productId)
        {
            var result = new Live();
            result.timestamp = null;
            result.isExecuteMain = null;
            result.isExecuteLast = null;

            var jsonObject = await Client.sendGetRequest("live", productId);
            var liveObj = jsonObject["live"];
            if (liveObj != null)
            {
                result.timestamp = (long)liveObj["timestamp"];
                result.isExecuteMain = (bool)liveObj["isExecuteMain"];
                result.isExecuteLast = (bool)liveObj["isExecuteLast"];
            }
            return result;
        }
        public static async Task<Context> getContext(string productId)
        {
            var context = new Context();
            var jsonObject = await Client.sendGetRequest("context", productId);
            var contextObj = jsonObject["context"];
            if(contextObj != null && contextObj.Type == JTokenType.Object)
            {
                context.orderPhase = (string)contextObj["orderPhase"];
                context.afterSendOrder = (bool?)contextObj["afterSendOrder"];
                context.orderId = (string)contextObj["orderId"];
                context.buyOrderPrice = (double?)contextObj["buyOrderPrice"];
                context.startBuyTimestamp = (long?)contextObj["startBuyTimestamp"];
                var executionSettingObj = contextObj["executionSetting"];
                if(executionSettingObj != null && executionSettingObj.Type == JTokenType.Object)
                {
                    context.executePhase = (bool?)executionSettingObj["executePhase"];
                    context.executeMain = (bool?)executionSettingObj["executeMain"];
                    context.makeNewOrder = (bool?)executionSettingObj["makeNewOrder"];
                }
            }
            return context;
        }
        public static async Task<bool> patchContext(string productId, JObject body)
        {
            var result = await Client.patchRequest("context", productId, body);
            return result.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
