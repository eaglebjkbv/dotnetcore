using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Session;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Internal;
using uPLibrary.Networking.M2Mqtt;
using System.Diagnostics;


namespace Mttq_Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            MqttClient client = new MqttClient("mqtt.eclipse.org");
            byte code = client.Connect(Guid.NewGuid().ToString());
            
             // publish olduğunda çağırılacak method.Aşağıda

            ushort msgId = client.Publish("ev/odasicakligi",
           Encoding.UTF8.GetBytes("Selamlar"),
           MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
           false);
           client.MqttMsgPublished += client_MqttMsgPublished;
          
        }
    // Bu Alt kısım nedense Hiç devreye girmiyor...
        static void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            Debug.WriteLine("MessageId = " + e.MessageId + " Published = " + e.IsPublished);



        }
    }
}

