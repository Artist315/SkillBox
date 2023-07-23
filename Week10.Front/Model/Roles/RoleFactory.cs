using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week10.Front.Model.Customers;

namespace Week10.Front.Model.Roles
{
    public static class RoleFactory
    {
        public static Worker GetModel(string role)
        {
            switch ((Roles)Enum.Parse(typeof(Roles), role))
            {
                case Roles.Manager:
                    return new ManagerModel();
                case Roles.Consultant:
                    return new ConsultantModel();
                default:
                    return null;
            }
        }
    }
}
