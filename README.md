# FreshBooks.Api

<strong>In progress - not yet ready for use</strong>

- Callbacks (OK)
- Categories (OK - not verified)
- Clients (OK - not verified)
- Estimates (OK - not verified)
- Expenses (OK - not verified)
- Gateway (OK - not verified)
- Invoices (OK - not verified)
- Items (OK - not verified)
- Languages (OK - not verified)
- Payments (OK - not verified)
- Projects (OK - not verified)
- Receipts (OK - not verified)
- Recurring (OK - not verified)
- Staff (OK - not verified)
- System (OK - not verified)
- Tasks (OK - not verified)
- Taxes (OK - not verified)
- Time Entries (OK - not verified)
- Contractors (OK - not verified)
- Default Terms (OK - not verified)
- Reports (OK - not verified)
- Currency (OK - not verified)
- Email Templates (OK - not verified)

## Limitations

Only supports token authentication at this time. OAuth 1.0 Rev. A is TBD.

## How to use the compiled Pcl assembly

Get a typed API with intellisense for interacting with the FreshBooks API, by simply
using an extension method off the C# HttpClient object. This allows you to use any
event handler pipeline(s) you want inside your HttpClient.

```csharp
new HttpClient().FreshBooks(account, token) ...
```

Then perform request/response as needed:

```csharp
var fb = new HttpClient().FreshBooks(account, token);
var request = new CallbackList.request();
var response = await fb.CallbackList(request);
var callbacks = response.callbacks; // that's it
```

## Error handling

To check for an exception, simply check the status:

```csharp
...
var response = await fb.CallbackList(request);
if(response.status == "fail")
{
    // request failed, get the error info
    var httpStatusCode = response.StatusCode;
    var freshbooksErrorMessage = response.error;
    var freshbooksErrorCode = response.code;
   
    // handle the error gracefully
    ...

} else {    // success, do something with the response
    var callbacks = response.callbacks;
    ...
}
```

You can also use a try/catch strategy, if you prefer. The following checks for an
unauthorized exception for example, by catching a FreshBooksException. Notice the Options
flag "ThrowOnFail = true".

```csharp
...
fb.Options.ThrowOnFail = true;
try
{
    var response = await client.CallbackList(request);    // success, do something with the response
    ...
}
catch (FreshBooksException ex)
{
    Assert.AreEqual(HttpStatusCode.Unauthorized, ex.StatusCode);
    Assert.AreEqual("Unauthorized", ex.Message);
    Assert.AreEqual("Authentication failed.", ex.error);
    
    // handle the error gracefully
    ...
}
```