using Api.Repository;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Api.DependencyInjection
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            using (IKernel kernel = new StandardKernel())
            {
                kernel.Bind<IUserRepository>()
                    .To<UserRepository>()
                    .InTransientScope();

                kernel.Bind<IDbConnection>()
                    .To<SqlConnection>()
                    .InTransientScope();
            }
        }
    }
}