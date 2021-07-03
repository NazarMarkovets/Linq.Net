using System.Collections.Generic;
using System.Diagnostics;
using MainApp.DataManager;
using MainApp.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppTest
{
    [TestClass]
    public class ListManagerModuleTest
    {
        private ListManager _listManager;

        [TestInitialize]
        public void StartUp()
        {
            _listManager = new ListManager();
        }
        
        [TestMethod]
        public void Test_ListManager_ReturnGeneratedUsersList_NotNull()
        {
            var list = ListManager.RetungGeneratedUsersList();
            list.ForEach(c =>Debug.Print($"\tUser:\n{c.Name}\n{c.Age}\n{c.Id}")); 
            Assert.IsNotNull(list);
        }
                
        [TestMethod]
        public void Test_ListManager_ReturnGeneratedStringsList_NotNull() 
        { 
            var List = _listManager.ReturnGeneratedStringsList(); 
            List.ForEach(c =>Debug.Print(c)); 
            Assert.IsNotNull(List);
        }
        
        [TestMethod] 
        public void Test_List_SetListByArray() 
        { 
            var List = new ListManager().SetStringListByArray(new[] {"str1", "str2"}); 
            Assert.IsNotNull(List); 
            Assert.IsTrue(List.Count > 0);
        }

        [TestMethod]
        public void Test_List_SetListByList()
        {
            List<string> stringList = new List<string>(){"newstr1", "newstr2"};
            var expectedList = _listManager.SetStringListByList(stringList);
            Assert.IsTrue(expectedList.Count > 0);
        }
    }
}