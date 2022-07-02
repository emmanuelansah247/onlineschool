payerId = getUrlParameter('PayerID');
paymentId= getUrlParameter('paymentId');
totalAmount = getUrlParameter('totalAmount');

function ExecutePayment(paymentUrl="Payment/OldStudentPaymentSuccessUrl",message_alert="Email envoyé"){

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
                        studentFeeToPayId = tmp.sku;
                        amountPaid = tmp.price;

                        var StudentPaymentViewModel = {
                            StudentFeeToPayId: studentFeeToPayId,
                            Amount : Number.parseFloat(amountPaid),
                            userId: document.getElementById('UserId').value,
                        };

                        var SaveApplication = $.ajax({
                            type: "POST",
                            url: baseUrl + paymentUrl,
                            data: StudentPaymentViewModel,
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