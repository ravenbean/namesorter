using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;

namespace UnitTestProject1
{
    [TestClass]
    public class SorterTest
    {
        [TestMethod]
        public void ReadUnsortedNames()
        {
            //Arrange
            string[] expected = new string[] {
                "Orson Milka Iddins",
                "Erna Dorey Battelle",
                "Flori Chaunce Franzel",
                "Odetta Sue Kaspar",
                "Roy Ketti Kopfen",
                "Madel Bordie Mapplebeck",
                "Selle Bellison",
                "Leonerd Adda Mitchell Monaghan",
                "Debra Micheli",
                "Hailey Annakin",
                "Leonerd Adda Micheli Monaghan",
                "Avie Annakin"
            };
            string filename = "unsorted-names-list.txt";
            Sorter sorter = new Sorter();

            //Act
            string[] actual = sorter.ReadUnsortedNames(filename);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortNames()
        {
            //Arrange
            string[] expected = new string[] {
                "Avie Annakin",
                "Hailey Annakin",
                "Erna Dorey Battelle",
                "Selle Bellison",
                "Flori Chaunce Franzel",
                "Orson Milka Iddins",
                "Odetta Sue Kaspar",
                "Roy Ketti Kopfen",
                "Madel Bordie Mapplebeck",
                "Debra Micheli",
                "Leonerd Adda Micheli Monaghan",
                "Leonerd Adda Mitchell Monaghan"
            };
            string filename = "unsorted-names-list.txt";
            Sorter sorter = new Sorter();

            //Act
            string[] names = sorter.ReadUnsortedNames(filename);
            string[] actual = sorter.SortNames(names);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
