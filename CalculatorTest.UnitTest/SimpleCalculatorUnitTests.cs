using System;
using CalculatorTest.CoreLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculatorTest.UnitTest
{
    [TestClass]
    public class SimpleCalculatorUnitTests
    {
        private SimpleCalculator _simplecalculator;  
        private Mock<IDiagnostics> _diagnostics;     

        [TestInitialize]
        public void Initialize()
        {
            _diagnostics = new Mock<IDiagnostics>();
            _simplecalculator = new SimpleCalculator(_diagnostics.Object);
        }
        [TestMethod]
        public void SimpleCalculator_Add2Numbers_ShouldReturnExpectedResult()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Add(12, 12);

            // Verify the result of addition
            Assert.AreEqual(result, 24);
        }
        [TestMethod]
        public void SimpleCalculator_Subtract2Numbers_ShouldReturnExpectedResult()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Subtract(12, 2);

            // Verify the result of Substraction
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        public void SimpleCalculator_Multiply2Numbers_ShouldReturnExpectedResult()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Multiply(12, 2);

            // Verify the result of Multiplication
            Assert.AreEqual(result, 24);
        }

        [TestMethod]
        public void SimpleCalculator_Divide2Numbers_ShouldReturnExpectedResult()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Divide(20, 2);

            // Verify the result of Divison 
            Assert.AreEqual(result, 10);
        }
        [TestMethod]
        //checks that the diagnostics interface is called with expected values
        public void SimpleCalculator_VerifyAddMethod_CallsDiagnostics()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Add(12, 12);

            //checks that the diagnostics interface is called with expected values
            _diagnostics.Verify((_ => _.LogCalculatedTotal(It.IsAny<string>(), It.IsAny<string>())), Times.Once());            
        }
        [TestMethod]
        //checks that the diagnostics interface is called with expected values
        public void SimpleCalculator_VerifySubtractMethod_CallsDiagnostics()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Subtract(12, 2);

            //checks that the diagnostics interface is called with expected values
            _diagnostics.Verify((_ => _.LogCalculatedTotal(It.IsAny<string>(), It.IsAny<string>())), Times.Once());
        }
        [TestMethod]
        //checks that the diagnostics interface is called with expected values
        public void SimpleCalculator_VerifyMultipleMethod_CallsDiagnostics()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Multiply(12, 2);

            //checks that the diagnostics interface is called with expected values
            _diagnostics.Verify((_ => _.LogCalculatedTotal(It.IsAny<string>(), It.IsAny<string>())), Times.Once());
        }
        [TestMethod]
        //checks that the diagnostics interface is called with expected values
        public void SimpleCalculator_VerifyDivideMethod_CallsDiagnostics()
        {
            //Setup Mock for Diagnostics
            _diagnostics.Setup(m => m.LogCalculatedTotal(It.IsAny<string>(),
                It.IsAny<string>()));
            var result = _simplecalculator.Divide(12, 2);

            //checks that the diagnostics interface is called with expected values
            _diagnostics.Verify((_ => _.LogCalculatedTotal(It.IsAny<string>(), It.IsAny<string>())), Times.Once());
        }
    }
}
