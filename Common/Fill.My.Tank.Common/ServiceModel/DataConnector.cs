using System.ServiceModel;

namespace Fill.My.Tank.Common.ServiceModel
{
    public static class DataConnector
    {

        public static string LoginName
        {
            get
            {
                var _LoginName = string.Empty;
                try
                {
                    _LoginName = OperationContext.Current.IncomingMessageHeaders.GetHeader<string>("String", "System");
                    if (_LoginName.IndexOf(@"\") > -1) _LoginName = string.Empty;
                }
                catch
                {
                    _LoginName = string.Empty;
                }

                return _LoginName;
            }
        }

    }
}
