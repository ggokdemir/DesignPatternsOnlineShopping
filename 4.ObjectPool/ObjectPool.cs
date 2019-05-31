
using System;
using System.Collections;

namespace OnlineShoppingCenter
{
    class CallCenter
    {
        // Maximum call center CallCenteremployees  
        private static int _PoolMaxSize = 2;

        private static readonly Queue objPool = new Queue(_PoolMaxSize);
        public CallCenterEmployee GetCallCenterEmployee()
        {
            CallCenterEmployee oCallCenterEmployee;
            // check from the collection pool. If exists return object else create new  
            if (CallCenterEmployee.Counter >= _PoolMaxSize && objPool.Count > 0)
            {
                // Retrieve from pool  
                oCallCenterEmployee = RetrieveFromPool();
            }
            else
            {
                oCallCenterEmployee = GetNewCallCenterEmployee();
            }
            return oCallCenterEmployee;
        }
        private CallCenterEmployee GetNewCallCenterEmployee()
        {
            // Creates a new CallCenteremployee  
            CallCenterEmployee oEmp = new CallCenterEmployee();
            objPool.Enqueue(oEmp);
            return oEmp;
        }
        protected CallCenterEmployee RetrieveFromPool()
        {
            CallCenterEmployee oEmp;
            // if there is any objects in my collection  
            if (objPool.Count > 0)
            {
                oEmp = (CallCenterEmployee)objPool.Dequeue();
                CallCenterEmployee.Counter--;
            }
            else
            {
                // return a new object  
                oEmp = new CallCenterEmployee();
            }
            return oEmp;
        }
    }
    class CallCenterEmployee
    {
        public static int Counter = 0;
        public CallCenterEmployee()
        {
            ++Counter;
        }
        private string _Firstname;
        public string Firstname
        {
            get
            {
                return _Firstname;
            }
            set
            {
                _Firstname = value;
            }
        }
        private string _Lastname;
        public string Lastname
        {
            get
            {
                return _Lastname;
            }
            set
            {
                _Lastname = value;
            }
        }
        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
    }
}
