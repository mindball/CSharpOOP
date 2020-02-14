using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace DependancyInjectionContainer
{
    //Example:https://rubikscode.net/2018/04/09/exploring-dependency-injection-in-c-and-top-3-di-containers-part-2/

    class CastleWindsorIoC
    {
        public CastleWindsorIoC()
        {
            //var castleContrainer = new WindsorContainer();
            //castleContrainer.Register(Component.For<Client>());
            //castleContrainer.Register(Component.For<IService1>()
            //        .ImplementedBy<Service1>());
            //castleContrainer.Register(Component.For<IService2>()
            //    .ImplementedBy<Service2>().LifestyleSingleton());

            //var client = castleContrainer.Resolve<Client>();
            //client.InitiateServiceMethods();

            ////The default lifestyle in Windsor is singleton
            //var client1 = castleContrainer.Resolve<Client>();
            //var client2 = castleContrainer.Resolve<Client>();
            //if(client1 != client2)
            //{
            //    throw new ApplicationException("Lifestyle problem!");
            //}

            //lifestyle transient
            var castleContrainer2 = new WindsorContainer();
            castleContrainer2.Register(Component.For<Client>().LifeStyle.Transient);
            
        }
    }

    public interface IService1
    {
        void Service1Method();
    }

    public interface IService2
    {
        void Service2Method();
    }

    public class Service1 : IService1
    {
        public void Service1Method()
        {
            Console.WriteLine("ServiceMethod() from: " 
                + this.GetType().Name);
        }
    }

    public class Service2 : IService2
    {
        public void Service2Method()
        {
            Console.WriteLine("ServiceMethod() from: "
                + this.GetType().Name);
        }
    }

    public class Client
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;

        public Client(IService1 service, IService2 service2)
        {
            _service1 = service;
            _service2 = service2;
        }
        public void InitiateServiceMethods()
        {
            _service1.Service1Method();
            _service2.Service2Method();
        }
    }
}
