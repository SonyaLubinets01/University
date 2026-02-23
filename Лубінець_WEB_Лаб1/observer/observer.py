class Subject:
    def __init__(self):
        self.observers = []

    def attach(self, observer):
        self.observers.append(observer)

    def notify(self, message):
        for observer in self.observers:
            observer.update(message)


class Observer:
    def update(self, message):
        print(f"Observer received: {message}")


def main():
    subject = Subject()

    observer1 = Observer()
    observer2 = Observer()

    subject.attach(observer1)
    subject.attach(observer2)

    subject.notify("State changed")


if __name__ == "__main__":
    main()