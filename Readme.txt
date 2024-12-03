There are 3 message senders which implement the IMessageSender interface in 3 different ways: via tcp, via http, and saving message in the text file.
These senders are located in the Senders folder.
NOT CHANGING neither the existing senders code nor Program.cs code, augment their behavior with the insistency.
It means that if we hadn't succeeded to send a message at first attempt, then we should try to send it second time, etc.
Let's stop this process when the number Of failed attempts = 5 or when the message is sent successfully.
Support your decision with the correspondent unit tests.
