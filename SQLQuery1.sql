create table employee_payroll(
Id int primary key identity,
name varchar(50),
phone varchar(15),
address varchar(100),
department varchar(20),
gender varchar(1),
basic_pay money,
deduction money,
taxable_pay money,
tax money,
netpay money,
startDate date
);


create proc SpAddEmployeeDetails
@EmployeeName varchar(50),
@PhoneNumber varchar(15),
@Address varchar(100),
@Department varchar(20),
@Gender varchar(1),
@BasicPay money,
@Deductions money,
@TaxablePay money,
@Tax money,
@NetPay money,
@StartDate date
as

insert into employee_payroll values (@EmployeeName, @PhoneNumber, @Address, @Department, @Gender, @BasicPay, @Deductions, @TaxablePay, @Tax, @NetPay, @StartDate)

go