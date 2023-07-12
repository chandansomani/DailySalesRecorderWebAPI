# WebAPITest1



Requirements Analysis			
			
Model	Farmer	FarmerID	int
		FarmerName	string
		FarmerPlace	string
		FarmerMobileNo	ulongint
		FarmerAadhaar	ulongint
		CreatedBy	int
		CreatedDate	datetime
		Modifiedby	int
		ModfifedDate	datetime
		isActive	bool
			
Enum	InvoiceType	SEED	0
		PESTICIDE	1
		FERTILIZER	2
			
Model	Invoice	InvoiceID	ulongint
		InvoiceType	int
		InvoiceNo	string
		Date	datetime
		FarmerID	int
		Amount	decimal
		CreditAmt	decimal
		CashAmt	decimal
		UPIAmt	decimal
		CreatedBy	int
		CreatedDate	datetime
		Modifiedby	int
		ModfifedDate	datetime
		isActive	bool
			
Model	User	UserID	int
		Username	string
		UserType	int
			
Enum	UserType	Admin	0
		Operator	1
