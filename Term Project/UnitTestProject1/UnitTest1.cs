using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Supporting;
using TheCompany;
using AllEmployees;
using Presentation;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /** 
         * Name: Normal_Valid_ReadFile(string file)
         * Purpose: To test the readFile function's ability to read multiple strings from a file.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      "test value 1"
         *      "test value 2"
         *      "test value 3"
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_ReadFile()
        {
            string file = "file.txt";
            List<string> expectedResult = new List<string>();
            expectedResult.Add("test value 1");
            expectedResult.Add("test value 2");
            expectedResult.Add("test value 3");
            List<string> actualResult = FileIO.ReadFile(file);
        }

        /** 
         * Name: Exception_Invalid_ReadFile(string file)
         * Purpose: To test the readFile function's behaviour when fed an invalid file.
         * It will be conducted automatically.
         * Type: Exception
         * Expected Results: 
         *      ""
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_ReadFile()
        {
            string file = "file.txt";
            List<string> expectedResult = new List<string>();
            expectedResult.Add("test value 1");
            expectedResult.Add("test value 2");
            expectedResult.Add("test value 3");
            List<string> actualResult = FileIO.ReadFile(file);
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_WriteFile(string record, string file)
         * Purpose: To test the writeFile function's ability to write a record to a file.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_WriteFile()
        {
        }

        /** 
         * Name: Exception_NoFile_WriteFile(string record, string file)
         * Purpose: To test the witeFile function's behaviour when fed an invalid file.
         * It will be conducted automatically.
         * Type: Exception
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Exception_WriteFile()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_WriteLog(string record)
         * Purpose: To test the writeLog function's ability to write a log to a file.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_WriteLog()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_VerifyItem(string record)
         * Purpose: To test the verifyItem function's ability to verify the validity of an employee.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_VerifyItem()
        {
        }

        /** 
         * Name: Normal_Invalid_VerifyItem(string record)
         * Purpose: To test the verifyItem function's ability to verify the invalidity of an employee.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_VerifyItem()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_loadDatabase(string record)
         * Purpose: To test the loadDatabase function's ability to load a database from a file, verify each record
         * validity, and add them to the container.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_loadDatabase()
        {
        }

        /** 
         * Name: Normal_Invalid_loadDatabase(string record)
         * Purpose: To test the loadDatabase function's ability to handle being fed an invalid file to load from.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_loadDatabase()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_saveContainer(string file)
         * Purpose: To test the saveContainer function's ability to save the database to a file.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_saveContainer()
        {
        }

        /** 
         * Name: Exception_Invalid_saveContainer(string file)
         * Purpose: To test the saveContainer function's ability to handle being fed an invalid file name.
         * It will be conducted automatically.
         * Type: Exception
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_saveContainer()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_addItem(string employee)
         * Purpose: To test the addItem function's ability to add a valid employee to the container.
         * It will be conducted automatically.
         * Type: Exception
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_addItem()
        {
        }

        /** 
         * Name: Normal_Invalid_addItem(string employee)
         * Purpose: To test the addItem function's ability to handle being fed an invalid employee.
         * It will be conducted automatically.
         * Type: Exception
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_addItem()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_removeItem(string ID)
         * Purpose: To test the removeItem function's ability to remove a valid employee from the container.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_removeItem()
        {
        }

        /** 
         * Name: Normal_Invalid_removeItem(string ID)
         * Purpose: To test the removeItem function's ability to handle being fed an invalid employee.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_removeItem()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_modiyItem(string ID, string field, string value)
         * Purpose: To test the modifyItem function's ability to modify a valid employee from the container.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_modifyItem()
        {
        }

        /** 
         * Name: Normal_Invalid1_modifyItem(string ID, string field, string value)
         * Purpose: To test the modifyItem function's ability to handle being fed an invalid employee.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid1_modifyItem()
        {
        }

        /** 
         * Name: Normal_Invalid2_modifyItem(string ID, string field, string value)
         * Purpose: To test the modifyItem function's ability to handle being fed an invalid field to modify.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid2_modifyItem()
        {
        }

        /** 
         * Name: Normal_Invalid3_modifyItem(string ID, string field, string value)
         * Purpose: To test the modifyItem function's ability to handle being fed an invalid value to insert.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      false
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid3_modifyItem()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_displayItem(int itterate)
         * Purpose: To test the displayItem function's ability to handle returning an employee to display with a valid itterator.
         * It will be conducted automatically.
         * Type: Normal
         * Expected Results: 
         *      true
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_displayItem()
        {
        }

        /** 
        * Name: Exception_Invalid_displayItem(int itterate)
        * Purpose: To test the displayItem function's ability to handle receiving an invalid itterator.
        * It will be conducted automatically.
        * Type: Exception
        * Expected Results: 
        *      false
        * Expected outcome: success
        * Actual outcome:
       */
        [TestMethod]
        public void Normal_Valid_displayItem()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_mainMenu()
         * Purpose: Test the mainMenu function's ability to display the main menu options and take user input.
         * It will be conducted manually. Each individual menu option will be input.
         * Type: Normal
         * Expected Results: 
         *      Display selected menu.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_mainMenu()
        {
        }

        /** 
         * Name: Normal_Invalid_mainMenu()
         * Purpose: Test the mainMenu function's ability to handle invalid input.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Normal
         * Expected Results: 
         *      Display error.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_mainMenu()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_manageFileMenu()
         * Purpose: Test the manageFileMenu function's ability to display the file management menu options and take user input.
         * It will be conducted manually. Each individual menu option will be input.
         * Type: Normal
         * Expected Results: 
         *      Display selected menu.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_manageFileMenu()
        {
        }

        /** 
         * Name: Normal_Invalid_manageFileMenu()
         * Purpose: Test the manageFileMenu function's ability to handle invalid input.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Normal
         * Expected Results: 
         *      Display error.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_mmanageFileMenu()
        {
        }

    //--------------------------------------------------

        /** 
         * Name: Normal_Valid_manageEmployeeMenu()
         * Purpose: Test the manageEmployeeMenu function's ability to display the employee management menu options and take user input.
         * It will be conducted manually. Each individual menu option will be input.
         * Type: Normal
         * Expected Results: 
         *      Display selected menu.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_manageEmployeeMenu()
        {
        }

        /** 
         * Name: Normal_Invalid_manageEmployeeMenu()
         * Purpose: Test the manageEmployeeMenu function's ability to handle invalid input.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Normal
         * Expected Results: 
         *      Display error.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_manageEmployeeMenu()
        {
        }

     //--------------------------------------------------

        /** 
         * Name: Normal_Valid_detailsMenu()
         * Purpose: Test the detailsMenu function's ability to display the employee management menu options and take user input.
         * It will be conducted manually. Each individual menu option will be input.
         * Type: Normal
         * Expected Results: 
         *      Display selected menu.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_detailsMenu()
        {
        }

        /** 
         * Name: Normal_Invalid_detailsMenu()
         * Purpose: Test the detailsMenu function's ability to handle invalid input.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Normal
         * Expected Results: 
         *      Display error.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Invalid_detailsMenu()
        {
        }

        /** 
         * Name: Boundary_Valid_detailsMenu()
         * Purpose: Test the detailsMenu function's ability to handle attempts to itterate past the end or beginning of the list.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Boundary
         * Expected Results: 
         *      Loop to beginning of list.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_detailsMenu()
        {
        }

        /** 
         * Name: Exception_Invalid_detailsMenu()
         * Purpose: Test the detailsMenu function's ability to handle attempts to itterate to a non existant employee.
         * It will be conducted manually. Invalid menu options will be input.
         * Type: Exception.
         * Expected Results: 
         *      Display error.
         * Expected outcome: success
         * Actual outcome:
        */
        [TestMethod]
        public void Normal_Valid_detailsMenu()
        {
        }
    }
}
