using di.example.framework;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddScoped<IPayment, Promptpay>();
builder.Services.AddScoped<IPayment, CreditCard>();
builder.Services.AddScoped<IPayment, EWallet>();
builder.Services.AddScoped<IPaymentFactory, PaymentFactory>();

builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();

var app = builder.Build();

var paymentSerivce = app.Services.GetRequiredService<IPaymentService>();
Console.WriteLine(paymentSerivce.PayByOrderNumber("Promptpay", "001", 100));
Console.WriteLine(paymentSerivce.PayByOrderNumber("CreditCard", "002", 200));
Console.WriteLine(paymentSerivce.PayByOrderNumber("E-Wallet", "003", 100));
