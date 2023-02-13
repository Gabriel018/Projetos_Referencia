
function telefone() {

    const tel = document.querySelector("#tel")
 
    
    tel.addEventListener("keypress", () => {
        const inputlength = tel.value.length

        
        if (inputlength ===  1) {
            tel.value.length += '('
        }

        if (inputlength ===  3 ) {
            tel.value.length += ')'
        }

        

       
    })


}








//function mascara_telefone(objeto) {
//    vr = objeto.value;
//    tam = vr.length;
//    if (tam < 11) {
//        objeto.value = '(' + vr.substr(0, 2) + ') ' + vr.substr(2, 4) + '-' + vr.substr(6, 4);
//    }
//}