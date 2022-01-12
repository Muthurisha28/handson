--now
SELECT GETDATE() AS _GETDATE;
SELECT SYSDATETIME() AS _SYSDATETIME;
SELECT CURRENT_TIMESTAMP AS _CURRENT_TIMESTAMP;

--current time
SELECT CURRENT_TIMESTAMP as time_stamp

--dateadd
SELECT DATEADD(year, 1, '2022/01/25') AS DateAdd

SELECT DATEADD(month, 2, '2017/08/25') AS DateAdd
SELECT DATEADD(month, -2, '2017/08/25') AS DateAdd
SELECT DATEADD(WEEK, 2, '2017/08/25') AS DateAdd

--datediff
select DATEDIFF(year,'2022/01/25','2012/01/25') 

select DATEDIFF(WEEK,'2022/01/25','2012/01/25') 

select DATEDIFF(SECOND,'2022/01/25','2012/01/25') 

--datepartstring
SELECT DATENAME(year, '2017/08/25') AS DatePartString

--datepartint
SELECT DATEPART(minute, '2017/08/25 08:36') AS DatePartInt;

SELECT DATEPART(TZOFFSET, '2017/08/25 08:36') AS DatePartInt;

SELECT DAY('2017/08/13 09:08') AS DayOfMonth
SELECT MONTH('2017/08/25') AS Month
SELECT YEAR('2017/08/25') AS Year

--current system date
SELECT GETUTCDATE()
SELECT SYSDATETIME() AS SysDateTime

--isdate returns 0 or 1
SELECT ISDATE('2017-08-25')
SELECT ISDATE('2017-08-35')