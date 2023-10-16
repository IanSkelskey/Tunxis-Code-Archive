SELECT CUSTOMER.CUS_CODE, CUS_BALANCE, ROUND(SUM(LINE_UNITS*LINE_PRICE), 2) As 'Total Purchases'
FROM CUSTOMER
INNER JOIN INVOICE
ON CUSTOMER.CUS_CODE = INVOICE.CUS_CODE
INNER JOIN LINE
ON INVOICE.INV_NUMBER = LINE.INV_NUMBER
GROUP BY CUS_CODE