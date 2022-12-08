
using BumboData.Models;
using BumboRepositories.Utils;

namespace BumboUnitTests
{
    public class PrognosisTests
    {
        private PrognosisService _prognosisService;
        private readonly Mock<IPrognosisRepository> _prognosisRepositoryMock = new Mock<IPrognosisRepository>();
        private readonly Mock<IStandardRepository> _standardRepositoryMock = new Mock<IStandardRepository>();


        [SetUp]
        public void Setup()
        {
            //_prognosisService = new PrognosisService(_prognosisRepositoryMock.Object, _standardRepositoryMock.Object);
        }

        [Test]
        public void GetCassierePrognoseTest_CorrectInput()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch();
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);


            var standardType = StandardType.CHECKOUT_EMPLOYEES;
            var value = 30;

            var standardDto = new Standard
            {
                Branch = branch,
                Key = standardType,
                Value = value
            };
            _standardRepositoryMock.Setup(x => x.Get(standardType, branch)).Returns(standardDto);
            //Act
            var result = _prognosisService.GetCassierePrognose(date, branchId);
            //Assert
            Assert.AreEqual(customerCount / value, result);
        }
        [Test]
        public void GetCassierePrognoseTest_NoPrognoses()
        {
            //Arange
            _prognosisRepositoryMock.Setup(x => x.GetByDate(It.IsAny<DateOnly>(), It.IsAny<int>())).Returns(() => null);
            var date = DateTime.Now;
            var branchId = 1;
            var branch = new Branch();
            var standardType = StandardType.CHECKOUT_EMPLOYEES;
            var value = 30;
            var standardDto = new Standard
            {
                Branch = branch,
                Key = standardType,
                Value = value
            };
            _standardRepositoryMock.Setup(x => x.Get(standardType, branch)).Returns(standardDto);
            //Act
            var result = _prognosisService.GetCassierePrognose(date, branchId);
            //Assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void GetCassierePrognoseTest_NoStandard()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch();
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);
            _standardRepositoryMock.Setup(x => x.Get(It.IsAny<StandardType>(), It.IsAny<Branch>())).Returns(() => null);
            //Act
            var result = _prognosisService.GetCassierePrognose(date, branchId);
            //Assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void GetFreshPrognose_CorrectInput()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch();
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);


            var standardType = StandardType.FRESH_EMPLOYEES;
            var value = 100;

            var standardDto = new Standard
            {
                Branch = branch,
                Key = standardType,
                Value = value
            };
            _standardRepositoryMock.Setup(x => x.Get(standardType, branch)).Returns(standardDto);
            //Act
            var result = _prognosisService.GetFreshPrognose(date, branchId);
            //Assert
            Assert.AreEqual(customerCount / value, result);
        }
        [Test]
        public void GetFreshPrognose_NoPrognosis()
        {
            //Arange
            _prognosisRepositoryMock.Setup(x => x.GetByDate(It.IsAny<DateOnly>(), It.IsAny<int>())).Returns(() => null);
            var date = DateTime.Now;
            var branchId = 1;
            var branch = new Branch();
            var standardType = StandardType.FRESH_EMPLOYEES;
            var value = 100;

            var standardDto = new Standard
            {
                Branch = branch,
                Key = standardType,
                Value = value
            };
            _standardRepositoryMock.Setup(x => x.Get(standardType, branch)).Returns(standardDto);
            //Act
            var result = _prognosisService.GetFreshPrognose(date, branchId);
            //Assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void GetFreshPrognose_NoStandard()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch();
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);


            var value = 100;


            _standardRepositoryMock.Setup(x => x.Get(It.IsAny<StandardType>(), It.IsAny<Branch>())).Returns(() => null);
            //Act
            var result = _prognosisService.GetFreshPrognose(date, branchId);
            //Assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void GetStockersPrognose_CorrectInput()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch()
            {
                Id = 1,
                ShelvingDistance = 100
            };
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);


            var standardTypeColi = StandardType.COLI_TIME;
            var valueColi = 5;
            var standardTypeShelfStocking = StandardType.SHELF_STOCKING_TIME;
            var valueShelfStocking = 30;
            var standardTypeShelfArrangement = StandardType.SHELF_ARRANGEMENT;
            var valueShelfArrangement = 30;


            var standardColiDto = new Standard
            {
                Branch = branch,
                Key = standardTypeColi,
                Value = valueColi
            };

            var standardShelfStockingDto = new Standard
            {
                Branch = branch,
                Key = standardTypeShelfStocking,
                Value = valueShelfStocking
            };

            var standardShelfArrangement = new Standard
            {
                Branch = branch,
                Key = standardTypeShelfArrangement,
                Value = valueShelfArrangement
            };
            _standardRepositoryMock.Setup(x => x.Get(standardTypeColi, branch)).Returns(standardColiDto);
            _standardRepositoryMock.Setup(x => x.Get(standardTypeShelfStocking, branch)).Returns(standardShelfStockingDto);
            _standardRepositoryMock.Setup(x => x.Get(standardTypeShelfArrangement, branch)).Returns(standardShelfArrangement);
            //Act
            var result = _prognosisService.GetStockersPrognoseHours(date, branchId);
            //Assert
            var timeSpentOnColiInMin = (valueColi + valueShelfStocking) * coliCount;
            var timeSpentOnShelfsInMin = (valueShelfArrangement * branch.ShelvingDistance) / 60;

            var timeNeeded = (Double)(timeSpentOnColiInMin + timeSpentOnShelfsInMin) / 60;
            Assert.AreEqual(timeNeeded, result);
        }
        [Test]
        public void GetStockersPrognose_NoPrognosis()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch()
            {
                Id = 1,
                ShelvingDistance = 100
            };

            _prognosisRepositoryMock.Setup(x => x.GetByDate(It.IsAny<DateOnly>(), It.IsAny<int>())).Returns(() => null);


            var standardTypeColi = StandardType.COLI_TIME;
            var valueColi = 5;
            var standardTypeShelfStocking = StandardType.SHELF_STOCKING_TIME;
            var valueShelfStocking = 30;
            var standardTypeShelfArrangement = StandardType.SHELF_ARRANGEMENT;
            var valueShelfArrangement = 30;


            var standardColiDto = new Standard
            {
                Branch = branch,
                Key = standardTypeColi,
                Value = valueColi
            };

            var standardShelfStockingDto = new Standard
            {
                Branch = branch,
                Key = standardTypeShelfStocking,
                Value = valueShelfStocking
            };

            var standardShelfArrangement = new Standard
            {
                Branch = branch,
                Key = standardTypeShelfArrangement,
                Value = valueShelfArrangement
            };
            _standardRepositoryMock.Setup(x => x.Get(standardTypeColi, branch)).Returns(standardColiDto);
            _standardRepositoryMock.Setup(x => x.Get(standardTypeShelfStocking, branch)).Returns(standardShelfStockingDto);
            _standardRepositoryMock.Setup(x => x.Get(standardTypeShelfArrangement, branch)).Returns(standardShelfArrangement);
            //Act
            var result = _prognosisService.GetStockersPrognoseHours(date, branchId);
            //Assert

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void GetStockersPrognose_NoStandard()
        {
            //Arange
            var date = DateTime.Now;
            var branchId = 1;
            var coliCount = 20;
            var customerCount = 300;
            var branch = new Branch()
            {
                Id = 1,
                ShelvingDistance = 100
            };
            var prognosisDto = new Prognosis
            {
                Id = 1,
                Date = date.ToDateOnly(),
                BranchId = branchId,
                Branch = branch,
                ColiCount = coliCount,
                CustomerCount = customerCount,
            };
            _prognosisRepositoryMock.Setup(x => x.GetByDate(date.ToDateOnly(), branchId)).Returns(prognosisDto);


            var standardTypeColi = StandardType.COLI_TIME;
            var valueColi = 5;
            var standardTypeShelfStocking = StandardType.SHELF_STOCKING_TIME;
            var valueShelfStocking = 30;
            var standardTypeShelfArrangement = StandardType.SHELF_ARRANGEMENT;
            var valueShelfArrangement = 30;



            _standardRepositoryMock.Setup(x => x.Get(It.IsAny<StandardType>(), It.IsAny<Branch>())).Returns(() => null);
            //Act
            var result = _prognosisService.GetStockersPrognoseHours(date, branchId);
            //Assert

            Assert.AreEqual(-1, result);
        }
    }
}