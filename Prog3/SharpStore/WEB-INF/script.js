$(document).ready(function(){
	$(".destaques").slick({
        dots: true,
        infinite: true
    });

    window.onscroll = function() {
	    if (window.pageYOffset > $(".logo img")[0].height)	{
	        $('.expand').css("height", $('.menu')[0].clientHeight);
	        if (!(hasClass($('.menu'),'fixed'))) {
	        	$('.menu').addClass('fixed');
	    	}
		} else {
	        $('.expand').css("height", 0);
        	$('.menu').removeClass('fixed');
    	}
	};
});

function Expand()	{
	if ($(".menu .item")[0].className == "item")	{
		$(".menu .item").addClass("expanditem");
		window.onscroll();
	}	else	{
		$(".menu .item").removeClass("expanditem");
		window.onscroll();
	}
}

function hasClass(element, cls) {
    return (' ' + element.className + ' ').indexOf(' ' + cls + ' ') > -1;
}