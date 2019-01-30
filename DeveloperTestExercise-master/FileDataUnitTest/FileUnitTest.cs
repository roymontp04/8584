using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FileData;

namespace FileDataUnitTest
{
    [TestClass]
    public class FileUnitTest
    {
        List<string> fileVersion = new List<string>() { "-v,--v, /v,--version" };
        List<string> fileSize = new List<string>() { "-s,--s, /s,--size" };
        string filePath = "c:/text.txt";
        FileBase objDetails = new FileBase();

        
        /// <summary>
        /// Test Get_File_Version method
        /// </summary>
        [TestMethod]
        public void Get_File_Version()
        {

            //Arrange           
            var version = "-v";
            var actual = string.Empty;
            var expected = ".";

            //Act
            if (fileVersion[0].Contains(version))
                actual = objDetails.getFileVersion(filePath);

            //Assert            
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        /// Test Get_File_Size method
        /// </summary>
        [TestMethod]
        public void Get_File_Size()
        {
            //Arrange                      
            var version = "-s";
            var actual = 0;
            var expected = ".";

            //Act
            if (fileSize[0].Contains(version))
                actual = objDetails.getFileSize(filePath);

            //Assert            
            Assert.IsFalse(actual.ToString().Contains(expected));
        }

        /// <summary>
        /// Test Get_File_Size_Parm_True method 
        /// </summary>
        [TestMethod]
        public void Get_File_Size_Parm_True()
        {
            //Arrange
            var version = "--s";
            var actual = false;

            //Act
            actual = fileSize[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }

        /// <summary>
        /// Test Get_File_Version_Parm_True method
        /// </summary>
        [TestMethod]
        public void Get_File_Version_Parm_True()
        {
            //Arrange
            var version = "--v";
            var actual = false;

            //Act
            actual = fileVersion[0].Contains(version);

            //Assert
            Assert.IsTrue(actual);
        }   


    }
}
