using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment1_QA;

namespace QAAssignment1.Tests
{

    [TestFixture]
    public class RectangleTest
    {

        Rectangle rectangle;


        [SetUp]
        public void Init()
        {
            rectangle = new Rectangle();
        }

        [Test]
        public void GetLength__defaultLength1_actualLength1()
        {
            //default value
            rectangle = new Rectangle();
            int actualLength = rectangle.GetLength();
            Assert.AreEqual(1, actualLength);

        }

        [Test]
        public void GetLength__InputLength2_actualLength2()
        {
            int inputLength = 2;
            int inputWidth = 3;
            rectangle = new Rectangle(inputLength, inputWidth);
            int actualLength = rectangle.GetLength();
            Assert.AreEqual(2, actualLength);

        }

        [Test]
        public void GetWidth__defaultWidth1_actualWidth1()
        {
            
            rectangle = new Rectangle();
            int actualWidth = rectangle.GetWidth();
            Assert.AreEqual(1, actualWidth);

        }

        [Test]
        public void GetWidth__inputWidth2_actualWidth2()
        {
            int inputLength = 5;
            int inputWidth = 2;
            Rectangle rectangle = new Rectangle(inputLength, inputWidth);
            int actualWidth = rectangle.GetWidth();
            Assert.AreEqual(2, actualWidth);

        }
        [Test]
        public void SetLength_inputLength4_actualLength4()
        {

            int inputLength = 4;
            rectangle = new Rectangle();
            int actualLength = rectangle.SetLength(inputLength);
            Assert.AreEqual(4, actualLength);

        }

        
        [Test]
        public void SetWidth_inputWidth3_actualWidth3()
        {
            rectangle = new Rectangle();
            int inputWidth = 3;
            int actualWidth = rectangle.SetLength(inputWidth);
            Assert.AreEqual(3, actualWidth);

        }

        [Test]
        public void GetPerimeter_inputLength4_inputWidth3()
        {

            int inputLength = 4;
            int inputWidth = 3;
            Rectangle rectangle = new Rectangle(inputLength, inputWidth);
            int actualPerimeter = rectangle.GetPerimeter();
            Assert.AreEqual(14, actualPerimeter);

        }

        [Test]
        public void GetArea_inputLength4_inputWidth3()
        {
            int inputLength = 4;
            int inputWidth = 3;
            Rectangle rectangle = new Rectangle(inputLength, inputWidth);
            int actualArea = rectangle.GetArea();
            Assert.AreEqual(12, actualArea);

        }

    }
}
