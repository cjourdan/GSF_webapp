public class association_String_WS
{
	private Dictionary<String, MethodInfo> assoc;
	private Dictionary<String, object[]> paramsForSubscriptions;
	private association_String_WS instance;
	
	private association_String_WS()
	{
		//TODO crée les assoc sur WS
		//et instanciation des variables membres
	}
	
	public association_String_WS getInstance()
	{
		if(instance == null){
			instance = new association_String_WS();
		}
		return instance;
	}
	
	public boolean addCallback(String nameToCall, MethodInfo correspondingMethod, object[] parameters)
	{
		assoc.add(nameToCall, correspondingMethod);
		paramsForSubscriptions.add(nameToCall, parameters);
	}
	public object call(String subscription)
	{
		assoc.get(subscription).invoke(parameters);
	}
}

association_String_WS.getInstance().addCallback("getGroupe",lo_service.getMethod("getTeam"),/*tes params*/ new object[]{});
Type object = (Type) association_String_WS.getInstance().call("getGroupe");
object.toList();