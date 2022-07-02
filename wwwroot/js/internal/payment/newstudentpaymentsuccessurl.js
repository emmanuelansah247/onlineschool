payerId = getUrlParameter('PayerID');
paymentId= getUrlParameter('paymentId');
totalAmount = getUrlParameter('totalAmount');

function ExecutePayment(paymentUrl="Payment/NewStudentPaymentSuccessUrl",message_alert="Email envoyé"){

    var getCredentials = $.ajax({
        type: "GET",
        url: baseUrl + "Payment/GetPaymentCredentials",
        dataType: "json",
        success: function(credentials){
            var params = {
                RunEnvironment: credentials.runEnvironment,
                ClientId: credentials.clientId,
                ClientSecret: credentials.clientSecret,
                totalAmount: totalAmount,
                paymentId: paymentId,
                payerId:payerId
            };

            var getPaymentLink = $.ajax({
                    type: "POST",
                    url: credentials.executePaymentUrl,
                    data: params,
                    dataType: "text",
                    success: function(paymentDetails){
                        paymentDetails = JSON.parse(paymentDetails);
                        tmp = paymentDetails['transactions'][0]["item_list"]["items"][0];
                        programmeId = tmp.sku;
                        amountPaid = tmp.price;
                        var PaymentViewModel = {
                            ProgrammeId: programmeId,
                            UserId: document.getElementById('UserId').value,
                            ProgramFee : Number.parseFloat(amountPaid),
                            UploadedCVFileName : localStorage.getItem('uploadedcvfilename'),
                            PaymentType: "Paid"
                        };

                        var SaveApplication = $.ajax({
                            type: "POST",
                            url: baseUrl + paymentUrl,
                            data: PaymentViewModel,
                            dataType: "json",
                            success: function(result){
                                    if(result){
                                        alert(message_alert);
                                    }
                            },
                            error: function() { 
                                alert("Something went wrong");
                            }
                        });
                    },
                    error: function() { 
                        alert("Something went wrong");
                    }
                });
        },
        error: function() { 
            alert("Something went wrong");
        }
  });
}