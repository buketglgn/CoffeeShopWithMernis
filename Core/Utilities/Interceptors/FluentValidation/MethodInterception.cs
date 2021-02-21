using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors.FluentValidation
{
   public class MethodInterception :MethodInterceptionBaseAttribute
    {
        public virtual void OnBefore(IInvocation invcation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnSuccess(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, System.Exception e) { }

        public override void Intercept(IInvocation invocation)
        {
            var IsSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch(Exception e)
            {
                IsSuccess = false;
                OnException(invocation, e);
            }
            finally
            {
                if (IsSuccess)
                {
                    OnSuccess(invocation);
                }
                OnAfter(invocation);
            }
        }

    }
}
