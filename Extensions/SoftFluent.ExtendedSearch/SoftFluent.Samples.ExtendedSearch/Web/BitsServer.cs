//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// CodeFluent Entities generated (http://www.softfluent.com). Date: .
namespace SoftFluent.Samples.ExtendedSearch.Web
{
	
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CodeFluent Entities", "1.0.01234.05678")]
    public partial class SoftFluent_Samples_SearchBitsServer: CodeFluent.Runtime.BinaryServices.BitsServer
    {
		private static SoftFluent_Samples_SearchBitsServer _current;

		public SoftFluent_Samples_SearchBitsServer()
			:this(CodeFluent.Runtime.CodeFluentContext.Get(SoftFluent.Samples.ExtendedSearch.Constants.SoftFluent_Samples_SearchStoreName))
		{
		}
		
		public SoftFluent_Samples_SearchBitsServer(CodeFluent.Runtime.CodeFluentContext context)
			:base(context)
		{
		}

        protected override void OnInformation(object ctx)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");
                
            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
			string entityTypeName;
			string propertyName;
			string entityKey;
			ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ExtendedSearch.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }

        protected override long OnDownload(object ctx, long start, long end)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");
                
            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
			string entityTypeName;
			string propertyName;
			string entityKey;
			ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ExtendedSearch.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }
		
		protected override void OnSessionClose(object ctx, CodeFluent.Runtime.BinaryServices.Session session)
        {
            if (ctx == null)
                throw new System.ArgumentNullException("ctx");

            if (session == null)
                throw new System.ArgumentNullException("session");

            if (!OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closing, ctx, true, null))
                return;

            System.Net.HttpListenerContext context = (System.Net.HttpListenerContext)ctx;
            
            string entityTypeName;
            string propertyName;
            string entityKey;
            ParseUri(context.Request.Url, out entityTypeName, out propertyName, out entityKey);
            OnSessionClose(context, session, entityTypeName, propertyName, entityKey);
            OnSessionChange(session, CodeFluent.Runtime.BinaryServices.SessionChangeType.Closed, ctx, false, null);
        }
        
        protected virtual void OnSessionClose(System.Net.HttpListenerContext context, CodeFluent.Runtime.BinaryServices.Session session, string entityTypeName, string propertyName, string entityKey)
        {
			
			throw new System.InvalidOperationException(SoftFluent.Samples.ExtendedSearch.Resources.Manager.GetStringWithDefault("bitsServerInvalidUrl", "Invalid url '{0}'.", new object[]{context.Request.Url}));
        }

		public static SoftFluent_Samples_SearchBitsServer Current
		{
			get
			{
				if (_current == null)
				{
					_current = new SoftFluent_Samples_SearchBitsServer();
				}
				return _current;
			}
		}
    }
	
}
