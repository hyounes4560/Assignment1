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
    class RectangleTest 
    {

        private Rectangle rectangle;
            

            [SetUp]
            public void Init()
            {
                rectangle = new Rectangle();
            }

            public void GetLength_expectedLength1()
            {
            

            int actualLength = rectangle.GetLength();
            Assert.AreEqual(6, actualLength);
            
            }

        public void SetLength_inputLength4_actualLength4()
        {

            int inputLength = 4; 
            int actualLength = rectangle.SetLength(inputLength);
            Assert.AreEqual(4, actualLength);


        }

        public void GetWidth_actualWidth1()
        {
            
            int actualWidth = rectangle.GetWidth();
            Assert.AreEqual(1, actualWidth);

        }

        public void SetWidth_inputWidth3_actualWidth3()
        {

            int inputWidth = 3;
            int actualWidth = rectangle.SetLength(inputWidth);
            Assert.AreEqual(3, actualWidth);

        }

        public void GetPerimeter_inputLength4_inputWidth3()
        {
                        
            int actualPerimeter= rectangle.GetPerimeter();
            Assert.AreEqual(14, actualPerimeter);

        }

        public void GetArea_inputLength4_inputWidth3()
        {

            int actualArea = rectangle.GetArea();
            Assert.AreEqual(12, actualArea);


        }



    }
    }
