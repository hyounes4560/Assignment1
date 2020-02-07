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

            int actualLength = rectangle.GetLength();
            Assert.AreEqual(1, actualLength);

        }

        [Test]
        public void GetWidth__defaultWidth1_actualWidth1()
        {

            int actualWidth = rectangle.GetWidth();
            Assert.AreEqual(1, actualWidth);

        }

        [Test]
        public void SetLength_inputLength4_actualLength4()
        {

            int inputLength = 4;
            int actualLength = rectangle.SetLength(inputLength);
            Assert.AreEqual(4, actualLength);

        }

        
        [Test]
        public void SetWidth_inputWidth3_actualWidth3()
        {

            int inputWidth = 3;
            int actualWidth = rectangle.SetLength(inputWidth);
            Assert.AreEqual(3, actualWidth);

        }

        [Test]
        public void GetPerimeter_inputLength1_inputWidth1()
        {

            int actualPerimeter = rectangle.GetPerimeter();
            Assert.AreEqual(4, actualPerimeter);

        }

        [Test]
        public void GetArea_inputLength1_inputWidth1()
        {

            int actualArea = rectangle.GetArea();
            Assert.AreEqual(1, actualArea);

        }

    }
}
