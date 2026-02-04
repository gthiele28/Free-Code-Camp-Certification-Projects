class Category:
    def __init__(self, name):
        self.name = name
        self.ledger = []

    def deposit(self, amount, description=""):
        self.ledger.append({'amount': amount, "description": description})

    def withdraw(self, amount, description=""):
        if self.check_funds(amount):
            self.ledger.append({'amount': -1 * amount, "description": description})
            return True
        else:
            return False

    def get_balance(self):
        amount = 0
        for transaction in self.ledger:
            amount += transaction["amount"]
        return amount

    def transfer(self, amount, otherCat):
        if self.withdraw(amount, description=f"Transfer to {otherCat.name}"):
            otherCat.deposit(amount, description=f"Transfer from {self.name}")
            return True
        else:
            return False

    def check_funds(self, amount):
        return amount <= self.get_balance()

    def __str__(self):
        title = self.name.center(30, "*") + "\n"
        items = ""
        for item in self.ledger:
            desc = item["description"][:23].ljust(23)
            amt = f'{item["amount"]:>7.2f}'
            items += desc + amt + "\n"
        total = f"Total: {self.get_balance()}"
        return title + items + total


def create_spend_chart(categories):
    spent_amounts = []
    for cat in categories:
        total_spent = 0
        for item in cat.ledger:
            if item["amount"] < 0:
                total_spent += -item["amount"]
        spent_amounts.append(total_spent)

    total_spent_all = sum(spent_amounts)

    percentages = []
    for spent in spent_amounts:
        perc = (spent / total_spent_all) * 100
        perc = int(perc // 10) * 10
        percentages.append(perc)

    lines = []
    lines.append("Percentage spent by category")

    for level in range(100, -1, -10):
        row = str(level).rjust(3) + "|"
        for p in percentages:
            if p >= level:
                row += " o "
            else:
                row += "   "
        row += " "
        lines.append(row)

    separator = "    " + "-" * (len(categories) * 3 + 1)
    lines.append(separator)

    max_len = max(len(cat.name) for cat in categories)
    for i in range(max_len):
        row = "     "
        for cat in categories:
            if i < len(cat.name):
                row += cat.name[i] + "  "
            else:
                row += "   "
        lines.append(row)

    return "\n".join(lines)