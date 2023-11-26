using Domain.NewDirectory;
using Domain.VeryNewDirectory;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1.0, true)]
        [InlineData(0.0, true)]
        [InlineData(0.1, true)]
        [InlineData(-0.1, false)]
        [InlineData(-1.0, false)]
        public void ShoulDepositMoneyIntoEmptyBankAccount(double moneyToDeposit, bool shouldDeposit)
        {
            BankAccount bankAccount = new BankAccount();
            var isDeposited = bankAccount.Deposit(moneyToDeposit);
            Assert.Equal(shouldDeposit, isDeposited);
        }

        [Theory]
        [InlineData(1.1, 1.1)]
        public void AddingMoney(double addMoney, double shouldBe)
        {
            BankAccount bankAccount = new BankAccount();

            bankAccount.Deposit(addMoney);
            var currentBalance = bankAccount.GetBalance();
            Assert.Equal(shouldBe, currentBalance);


        }
    }
    public class GreatestCommonDivisorTests
    {
            [Theory]
            [InlineData(48, 18, 6)]
            [InlineData(27, 9, 9)]
            [InlineData(17, 5, 1)]
            [InlineData(50, 20, 10)]
            public void GCDiterative_ReturnsCorrectResult(int a, int b, int expected)
            {
                
                var result = GreatestCommonDivisor.GCDiterative(a, b);

                
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData(48, 18, 6)]
            [InlineData(27, 9, 9)]
            [InlineData(17, 5, 1)]
            [InlineData(50, 20, 10)]
            public void GCDrecursive_ReturnsCorrectResult(int a, int b, int expected)
            {
                
                var result = GreatestCommonDivisor.GCDrecursive(a, b);

                Assert.Equal(expected, result);
            }
        }
    public class LZWTests
    {
        [Theory]
        [InlineData("ABABABA", new[] { 65, 66, 256, 258, 257 })]
        [InlineData("HELLOHELLO", new[] { 72, 69, 76, 76, 79, 257, 260 })]
        [InlineData("AAAABBBCCDAA", new[] { 65, 65, 65, 65, 66, 66, 67, 67, 68, 256, 260 })]
        public void Compress_ReturnsCorrectResult(string input, int[] expected)
        {
           
            List<int> result = LZW.Compress(input);

           
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 65, 66, 256, 258, 257 }, "ABABABA")]
        [InlineData(new[] { 72, 69, 76, 76, 79, 257, 260 }, "HELLOHELLO")]
        [InlineData(new[] { 65, 65, 65, 65, 66, 66, 67, 67, 68, 256, 260 }, "AAAABBBCCDAA")]
        public void Decompress_ReturnsCorrectResult(int[] input, string expected)
        {
           
            string result = LZW.Decompress(new List<int>(input));


            Assert.Equal(expected, result);
        }
    }
    public class NumberSwapTests
    {
        [Theory]
        [InlineData(5, 10, 10, 5)]  
        [InlineData(0, 0, 0, 0)]     
        [InlineData(-5, 5, 5, -5)]   
        [InlineData(int.MinValue, int.MaxValue, int.MaxValue, int.MinValue)]   
        public void NormalVariableSwap_ReturnsCorrectResult(int x, int y, int expectedX, int expectedY)
        {
            
            int resultX, resultY;

            
            NumberSwap.NormalVariableSwap(x, y, out resultX, out resultY);

            
            Assert.Equal(expectedX, resultX);
            Assert.Equal(expectedY, resultY);
        }

        [Theory]
        [InlineData(5, 10, 10, 5)] 
        [InlineData(0, 0, 0, 0)]    
        [InlineData(-5, 5, 5, -5)]   
        [InlineData(int.MinValue, int.MaxValue, int.MaxValue, int.MinValue)]  
        public void MagicVariableSwap_ReturnsCorrectResult(int x, int y, int expectedX, int expectedY)
        {
           
            int resultX, resultY;

           
            NumberSwap.MagicVariableSwap(x, y, out resultX, out resultY);

            
            Assert.Equal(expectedX, resultX);
            Assert.Equal(expectedY, resultY);
        }
    }
    public class BankAccountTests
    {
        [Fact]
        public void NewBankAccount_HasZeroBalance()
        {
            
            var account = new BankAccount();

            
            var balance = account.GetBalance();

            
            Assert.Equal(0, balance);
        }

        [Theory]
        [InlineData(100, 100)]
        [InlineData(50.5, 50.5)]
        [InlineData(0, 0)]
        [InlineData(-10, 0)] 
        public void Deposit_IncreasesBalance(double depositAmount, double expectedBalance)
        {
            
            var account = new BankAccount();

            
            var result = account.Deposit(depositAmount);

            
            Assert.True(result); 
            Assert.Equal(expectedBalance, account.GetBalance());
        }

        [Theory]
        [InlineData(50, 30, 20)] 
        [InlineData(100, 30, 30)]
        [InlineData(-10, 30, 30)] 
        public void Withdraw_DecreasesBalance(double initialBalance, double withdrawalAmount, double expectedBalance)
        {
           
            var account = new BankAccount();
            account.Deposit(initialBalance);

            
            var result = account.Withdraw(withdrawalAmount);

           
            Assert.Equal(expectedBalance, account.GetBalance());
            Assert.Equal(expectedBalance >= 0, result);
        }
    }
    public class CarTests
    {
        [Fact]
        public void NewCar_HasZeroPassengers()
        {
            
            var car = new Car(5);

           
            var numberOfPassengers = car.GetNumberOfPassengers();

           
            Assert.Equal(0, numberOfPassengers);
        }

        [Theory]
        [InlineData(5, 3, 3)] 
        [InlineData(10, 15, 0)]
        [InlineData(5, -2, 0)] 
        public void AddPassengers_UpdatesPassengerCount(int maxPassengers, int passengersToAdd, int expectedPassengers)
        {
           
            var car = new Car(maxPassengers);

          
            var result = car.AddPassengers(passengersToAdd);
            var numberOfPassengers = car.GetNumberOfPassengers();

            
            Assert.Equal(expectedPassengers, numberOfPassengers);
            Assert.Equal(expectedPassengers == 0, !result);
        }

        [Fact]
        public void NewCar_HasMaxNumberOfPassengers()
        {
          
            var maxPassengers = 5;
            var car = new Car(maxPassengers);

          
            var actualMaxPassengers = car.MaxNumberOfPassengers;

            
            Assert.Equal(maxPassengers, actualMaxPassengers);
        }
    }


}