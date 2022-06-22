using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WinForm
{
    internal class DependencyResolver : NinjectModule
    {
        private static IKernel kernel = new StandardKernel();

        static DependencyResolver instance;
        public static DependencyResolver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DependencyResolver();
                }

                return instance;
            }
        }

        public override void Load()
        {
            Bind<Form1>().To<Form1>().InSingletonScope();
            Bind<Form2>().To<Form2>().InSingletonScope();
        }

        public T Resolve<T>()
        {
            return kernel.Get<T>();
        }
    }
}
