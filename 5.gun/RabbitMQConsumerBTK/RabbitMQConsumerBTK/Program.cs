// See https://aka.ms/new-console-template for more information
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQConsumerBTK;

Console.WriteLine("Hello, World!");
var factory = new ConnectionFactory()
{
    HostName = "localhost",
    Port = 5672,
    UserName = "guest",
    Password = "guest"
};

using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    //bağlanacağımız kuyruğun adını belirtiyoruz 
    channel.QueueDeclare(queue: "btkakademiq",
                       durable: false,
                       exclusive: false,
                       autoDelete: false,
                       arguments: null);
    //Event Delegate 
    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        //kuyruktan okumaya başlayacak
        var body = ea.Body.ToArray();
        //Byte array olrarak kuyruktan okuduğu veriyi önce String e dönüştürecek

        var message = Encoding.UTF8.GetString(body);
        Product p1 = new Product();
        //String olarak dönüştürdüğü veriye DeSerialezi ile tekra produc objesine dönüşütürecek
        p1 = JsonConvert.DeserializeObject<Product>(message);
        Console.WriteLine(" [x] Alınan mesaj {0}", p1.Name);
        Console.WriteLine(" Alınan {0}", message);

    };

    channel.BasicConsume(queue: "btkakademiq",
                     autoAck: true,
                     consumer: consumer);

    Console.WriteLine(" Çıkmak için bi tuşa basın");
    Console.ReadLine();
}