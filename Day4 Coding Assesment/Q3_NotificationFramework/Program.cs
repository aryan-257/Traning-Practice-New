using Q3_NotificationFramework;

var manager = new NotificationManager();

manager.Send("Your OTP is 1234" ,
    new EmailNotification() ,
    new SMSNotification() ,
    new WhatsAppNotification() ,
    new PushNotification()
);
