 
function remplirJour(){
	for (var i = 1; i <= 31; i++) {
		document.getElementById('jour').innerHTML+='<option value="'+ i +'"> date '+ i +'</option>'; 

	}
}

remplirJour();

function remplirMois(){
	var tabMois = new Array('Janvier','Fevrier','Mars','Avril','Mai','Juin','Juillet','Aout','Septembre','Octobre','Novembre','Decembre');
	for (var i = 0; i <= 11; i++)
		{
			document.getElementById('mois').innerHTML+='<option value="' + (i+1) +'">'+ tabMois[i] + '</option>';
		}
}

remplirMois();

function remplirAnnees(){
	var maDate = new Date();
	var annee = maDate.getFullYear();
	for (var i = annee; i >= (annee - 120); i--) {
		document.getElementById('annee').innerHTML+='<option value="'+ i +'">'+ i +'</option>';
	}
}

remplirAnnees();

function afficherCivilite() {
uneoption=document.createElement('option');
uneoption.value="1";
uneoption.text="Mlle";
document.getElementById("civil").options[0]=uneoption;

uneoption=document.createElement('option');

uneoption.value="2";
uneoption.text="Me";
document.getElementById("civil").options[1]=uneoption;

uneoption=document.createElement('option');
uneoption.value="3";
uneoption.text="M.";
document.getElementById("civil").options[2]=uneoption;

}

afficherCivilite();

 $('.close').on('click',function(){
        var current = $(this).parent();
        if (navigator.cookieEnabled) {
            cookieAdd=true;
            current.animate({right:'-300px'},500,'swing',function(){
                current.remove();
                alert('DDDDDDDDDDDDDDDDDDDDDD');
            });
        }
        
    });

function valNum(_chaine){
	var sommeChaine = 0;
	var maChaine = _chaine.toUpperCase();
	for (var i = 0; i < maChaine.length; i++ ){
		sommeChaine +=  maChaine.charCodeAt(i) - 64;
	}
	return sommeChaine;
}

function calculerSigne(_mois){
	var signe = ["Verseau","Poisson","Bélier","Taureau","Gémeaux","Cancer","Lion","Vierge",
	"Balance","Scorpion","Sagittaire","Capricorne"];
	return signe[_mois - 1]; 
}

function formOK (){

	return true;
}

function calculerPseudo(){
	var somme = valNum(document.getElementById("nom").value)
	+ valNum(document.getElementById("prenom").value);
	var result = "indéterminé";
	if (formOK() == true){
		result= calculerSigne(document.getElementById("mois").value) + somme;
	}
	alert(result);
}
var boutonval = document.getElementById("validation");
boutonval.addEventListener('click', calculerPseudo, true);
