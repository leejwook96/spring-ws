//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// InfoVersionComment, WseWsdl2, Version=2.0.3.0, Culture=neutral, PublicKeyToken=26ba029e599ec4f8, RunTime Version: 1.1.4322.2032
// 
using System;
using System.Xml;
using Microsoft.Web.Services2;
using Microsoft.Web.Services2.Addressing;
using Microsoft.Web.Services2.Messaging;
using System.Xml.Serialization;


[SoapService("http://www.springframework.org/spring-ws/samples/airline/definitions")]
public class AirlineService : SoapClient 
{
	public AirlineService() : base( new Uri("http://localhost:8080/airline/Airline") )
	{
	}

	[SoapMethod("http://www.springframework.org/spring-ws/samples/airline/GetFlights")]
	public SoapEnvelope GetFlights( SoapEnvelope request )
	{
		return base.SendRequestResponse("GetFlights", request);
	}

	public IAsyncResult BeginGetFlights( SoapEnvelope request, System.AsyncCallback callback, object asyncState)
	{
		return base.BeginSendRequestResponse("GetFlights", request, callback, asyncState);
	}

	public SoapEnvelope EndGetFlights( System.IAsyncResult asyncResult )
	{
		return base.EndSendRequestResponse(asyncResult);
	}

	[SoapMethod("http://www.springframework.org/spring-ws/samples/airline/BookFlight")]
	public SoapEnvelope BookFlight( SoapEnvelope request )
	{
		return base.SendRequestResponse("BookFlight", request);
	}

	public IAsyncResult BeginBookFlight( SoapEnvelope request, System.AsyncCallback callback, object asyncState)
	{
		return base.BeginSendRequestResponse("BookFlight", request, callback, asyncState);
	}

	public SoapEnvelope EndBookFlight( System.IAsyncResult asyncResult )
	{
		return base.EndSendRequestResponse(asyncResult);
	}

	[SoapMethod("http://www.springframework.org/spring-ws/samples/airline/GetFrequentFlyerMileage")]
	public SoapEnvelope GetFrequentFlyerMileage( SoapEnvelope request )
	{
		return base.SendRequestResponse("GetFrequentFlyerMileage", request);
	}

	public IAsyncResult BeginGetFrequentFlyerMileage( SoapEnvelope request, System.AsyncCallback callback, object asyncState)
	{
		return base.BeginSendRequestResponse("GetFrequentFlyerMileage", request, callback, asyncState);
	}

	public SoapEnvelope EndGetFrequentFlyerMileage( System.IAsyncResult asyncResult )
	{
		return base.EndSendRequestResponse(asyncResult);
	}

}
