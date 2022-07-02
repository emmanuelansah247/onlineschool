
function getUrlParameter(sParam) {
        var sPageURL = decodeURIComponent(window.location.search.substring(1)),
            sURLVariables = sPageURL.split('&'),
            sParameterName,
            i;

        for (i = 0; i < sURLVariables.length; i++) {
            sParameterName = sURLVariables[i].split('=');

            if (sParameterName[0] === sParam) {
                return sParameterName[1] === undefined ? true : sParameterName[1];
            }
        }
}


function bimChangeApplicationLanguage(){

    var bim_edu_language = document.getElementById('bim_edu_language');

    bim_edu_language.onchange = function(){
        var tmp_language = bim_edu_language.options[bim_edu_language.selectedIndex].value;
        if(tmp_language !="fr"){
            if(location.href == baseUrl){
                location.href =  baseUrl + tmp_language + "_home/index";     
            }else{              

                var controller_action_path = location.href.split(baseUrl)[1];
                if(controller_action_path.startsWith(tmp_language) == false ){
                    location.href =  baseUrl + tmp_language + "_home/index";
                }
            }
        }else{

            if(location.href == baseUrl){
              location.href =  baseUrl;
            }else{
                var controller_action_path = location.href.split(baseUrl)[1];
                location.href =  baseUrl + controller_action_path.split('_')[1];
            }

        }
    }
}