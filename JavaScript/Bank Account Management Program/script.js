class BankAccount {
    constructor () {
      this.balance = 0;
      this.transactions = [];
    }
  
    deposit (amount) {
      if (amount > 0){
        this.balance += amount;
        this.transactions.push({
          type: "deposit",
          amount: amount
        });
        return `Successfully deposited $${amount}. New balance: $${this.balance}`;
      } else {
        return "Deposit amount must be greater than zero.";
      }
    }
  
    withdraw (amount) {
      if (amount > 0 && amount <= this.balance) {
        this.balance -= amount;
        this.transactions.push({
          type: "withdraw",
          amount: amount
        });
        return `Successfully withdrew $${amount}. New balance: $${this.balance}`;
      } else {
        return "Insufficient balance or invalid amount.";
      }
    }
  
    checkBalance () {
        return `Current balance: $${this.balance}`;
    }
  
    listAllDeposits () {
      let str = "Deposits: ";
      this.transactions.forEach((transaction) => {
        if (transaction.type === "deposit") {
          str += transaction.amount + ",";
        }
      });
      return str.slice(0, str.length - 1);
    }
  
    listAllWithdrawals () {
      let str = "Withdrawals: ";
      this.transactions.forEach((transaction) => {
        if (transaction.type === "withdraw") {
          str += transaction.amount + ",";
        }
      });
      return str.slice(0, str.length - 1);
    }
  }
  
  const myAccount = new BankAccount();
  
  console.log(myAccount.deposit(1000));
  console.log(myAccount.withdraw(200));
  console.log(myAccount.withdraw(50));
  console.log(myAccount.withdraw(10));
  console.log(myAccount.deposit(100));
  console.log(myAccount.deposit(-50));
  console.log(myAccount.withdraw(-50));
  console.log(myAccount.withdraw(10000));
  
  console.log(myAccount.listAllDeposits());
  console.log(myAccount.listAllWithdrawals());
  
  console.log(myAccount.checkBalance());
  
  const testAccount = new BankAccount();
  testAccount.deposit(1000);
  testAccount.withdraw(20);
  testAccount.withdraw(50);
  testAccount.withdraw(100);
  console.log(testAccount.listAllWithdrawals());