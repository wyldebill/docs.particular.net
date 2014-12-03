﻿namespace Snippets_5.Distributor
{
    using NServiceBus;

    class ConfiguringWorker
    {
        public void Foo()
        {
            #region ConfiguringWorker
            var configuration = new BusConfiguration();
            configuration.EnlistWithMSMQDistributor();
            #endregion
        }
    }
}