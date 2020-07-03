using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Gsf.TestFwk.Web.Models
{
    public class Association_String_WS
    {
        private Dictionary<String, MethodInfo> assoc;
        private Dictionary<String, object[]> paramsForSubscriptions;
        private Dictionary<String, object> support;
        private static Association_String_WS instance;

        private Association_String_WS()
        {
            assoc = new Dictionary<string, MethodInfo>();
            paramsForSubscriptions = new Dictionary<string, object[]>();
            support = new Dictionary<string, object>();
        }
            Type lo_Type = Type.GetType("ServiceHR.POCServicePortTypeClient");

        public static Association_String_WS getInstance()
        {
            if (instance == null)
            {
                instance = new Association_String_WS();
            }
            return instance;
        }

        public Boolean addCallback(String nameToCall, object obj, MethodInfo correspondingMethod, object[] parameters)
        {
            if (!assoc.ContainsKey(nameToCall))
            {
                assoc.Add(nameToCall, correspondingMethod);
                paramsForSubscriptions.Add(nameToCall, parameters);
                support.Add(nameToCall, obj);
                return true;
            }
            return false;
        }

        public Boolean addCallback(String nameToCall, object obj, MethodInfo correspondingMethod)
        {
            if (!assoc.ContainsKey(nameToCall))
            {
                assoc.Add(nameToCall, correspondingMethod);
                support.Add(nameToCall, obj);
                return true;
            }
            return false;
        }

        public object call(String subscription)
        {
            return assoc[(subscription)].Invoke(support[subscription],paramsForSubscriptions[subscription]);
        }

        public object call(String subscription, object[] parameters)
        {
            object retour = assoc[(subscription)].Invoke(support[subscription], parameters);
            ((ServiceHR.POCServicePortTypeClient)support[subscription]).Close();
            return retour;
        }

        public void initAllCallbackWithoutParameters()
        {
            assoc = new Dictionary<string, MethodInfo>();
            paramsForSubscriptions = new Dictionary<string, object[]>();
            support = new Dictionary<string, object>();

            ServiceHR.POCServicePortTypeClient lo_service = new ServiceHR.POCServicePortTypeClient();
            Type type = lo_service.GetType();
            addCallback("search", lo_service, type.GetMethod("getEmployes"));

            lo_service = new ServiceHR.POCServicePortTypeClient();
            type = lo_service.GetType();
            addCallback("team", lo_service, type.GetMethod("getTeam"));

            lo_service = new ServiceHR.POCServicePortTypeClient();
            type = lo_service.GetType();
            addCallback("fiche", lo_service, type.GetMethod("getFicheEmploye"));

            lo_service = new ServiceHR.POCServicePortTypeClient();
            type = lo_service.GetType();
            addCallback("photo", lo_service, type.GetMethod("getPhoto"));
        }
    }
}