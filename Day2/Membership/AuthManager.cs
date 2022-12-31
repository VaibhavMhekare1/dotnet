namespace Membership;

public static class AuthManager{
  public static Boolean Validate(string email,string password)
  {
    Boolean status=false;
    if(email=="abc@gmail.com" && password=="root")
    {
        status=true;
    }
    return status;
  }

  public static Boolean Register(string firstname,string lastname,string email,string contactnumber,string location)
  {
    Boolean status=false;
    try{
       User u1=new User(firstname,lastname,email,contactnumber,location);
       status=true;
    }catch(Exception e){
         
    }
    return status;
  }
}