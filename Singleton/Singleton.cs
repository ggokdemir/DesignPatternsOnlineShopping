using System;

namespace OnlineShoppingCenter
{
    public class SiteAdminSingleton
    {
        private static int _adminId;
        private static SiteAdminSingleton _instance;
        protected SiteAdminSingleton(int adminId)
        {
            _adminId = adminId;
        }

        public static SiteAdminSingleton getInstance(int adminId)
        {
            {

                if (_instance == null)

                {

                    _instance = new SiteAdminSingleton(adminId);

                }



                return _instance;

            }
        }
    }

}
