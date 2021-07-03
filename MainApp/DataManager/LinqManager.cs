﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MainApp.DTO;

namespace MainApp.DataManager
{
    public class LinqManager
    {
        private static ArrayList _collectionToShow = new();

        #region Showing Results
            public void ReturnGeneralCollection()
            {
                foreach (var element in _collectionToShow) ShowResult(element);
            }

            public static void ShowResult(Object obj)
            {
                Console.WriteLine("\t==Result:==");
                if(obj is List<string> list)
                    list.ForEach(c=>Console.WriteLine(c));
                if (obj is List<User> listUser)
                    listUser.ForEach(usr => Console.WriteLine($"Name: {usr.Name} ID: {usr.Id}"));
                if (obj is Dictionary<string, User> dictUser)
                    dictUser.Values.ToList().ForEach(usr => Console.WriteLine($"Name: {usr.Name} ID: {usr.Id}"));
                if(obj is User user)
                    Console.WriteLine($"Name: {user.Name}, Age:{user.Age}, Salary: {user.Salary} ID: {user.Id}");
            }
            public static void AddToGeneralCollection(Object objectToAdd)
            {
                if (_collectionToShow != null) _collectionToShow.Add(objectToAdd);
            }
        #endregion

        #region LINQ Queries
        
            public static void LinqSelect()
            {
                Console.WriteLine("\t==Linq Select all users==");
                
                var list = ListManager.RetungGeneratedUsersList();
                var result = list.Select(c => c).ToList();
                result.ForEach(item => ShowResult(item));
            }

            public static void LinqSelectByParameter()
            {
                Console.WriteLine("\n\t==Linq Select By Parameter==\nList of the Users:");
                
                List<User> users = new();
                users.AddRange(ListManager.RetungGeneratedUsersList());
                users.Add(new User("Ivan", "Surname", 20, 20.3d, Guid.NewGuid()));
                users.ForEach(us=>ShowResult(us));
                
                    var result = users.Where(c => c.Name.Equals("Ivan")).ToList();
                    Console.WriteLine("=Selected User=");
                    result.ForEach(user=>ShowResult(user));
            }

            public static void LinqTakeWhile()
            {
                Console.WriteLine("\n\t==Linq Take While==");
                
                List<User> users = new();
                users.AddRange(ListManager.RetungGeneratedUsersList());
                users.ForEach(us=>ShowResult(us));
                Console.WriteLine("\n\t**Users between 18 and 50");
                    var result = users.TakeWhile(c=>c.Age<90).ToList();
                    if(result.Count==0) Console.WriteLine($"Function Take while close work because first user has age: {users.First().Age}");
                    result.ForEach(i=>ShowResult(i));
            }

            public static void LinqSelectSortedByAgeDesc()
            {
                Console.WriteLine("\n\t==Linq Sort by age desc==");
                
                List<User> users = new();
                users.AddRange(ListManager.RetungGeneratedUsersList());
                users.ForEach(us=>ShowResult(us));
                Console.WriteLine("\n\t **Sort by Age desc");
                var result = users.OrderByDescending(users => users.Age).ToList();
                result.ForEach(u=>ShowResult(u));
            }
            
            public static void LinqSelectLastOrDefault()
            {
                Console.WriteLine("\n\t==Linq Last Or default==");
                
                List<User> users = new();
                users.AddRange(ListManager.RetungGeneratedUsersList());
                users.ForEach(us=>ShowResult(us));
                Console.WriteLine("\n\t **Last:");
                ShowResult(users.ToHashSet().LastOrDefault()as User);
            }
            
        #endregion
    }
}