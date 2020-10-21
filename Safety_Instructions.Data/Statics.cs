using Firebase.Database;

namespace Safety_Instructions.Data
{
    public class Statics
    {
        public Statics()
        {
            FirebaseClient firebase = new FirebaseClient("https://testproj-f4c94.firebaseio.com/");
        }

    }
}
