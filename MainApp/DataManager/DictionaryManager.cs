using System.Collections.Generic;
using MainApp.DTO;

namespace MainApp.DataManager
{
    public class DictionaryManager
    {
        public Dictionary<string, User>? UsersDictionary;

        public Dictionary<string, User> FillDictionaryFromList(List<User> receivedList)
        {
            UsersDictionary = new Dictionary<string, User>();
            receivedList.ForEach(value=>UsersDictionary.Add(value.Id.ToString(), value));

            return UsersDictionary;
        }
    }
}