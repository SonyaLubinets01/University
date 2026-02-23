class OldPrinter:
    def print_text(self, text):
        print(f"Old printer prints: {text}")


class PrinterAdapter:
    def __init__(self, old_printer):
        self.old_printer = old_printer

    def print(self, text):
        self.old_printer.print_text(text)


def main():
    old_printer = OldPrinter()
    printer = PrinterAdapter(old_printer)

    printer.print("Hello Adapter Pattern")


if __name__ == "__main__":
    main()