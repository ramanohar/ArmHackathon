$(document).ready(function(){
	var mainbottom = $('.text-container').offset().top;
	
	$(window).on('scroll',function(){
		stop = Math.round($(window).scrollTop());
		if(stop > mainbottom){
			$('.top-bar').css('background-color','#fff');
			$('.item-container ul').css('color', '#000');
			$('#logo').attr('src','img/arm-logo-blue.svg');
		}else{
			$('.top-bar').css('background-color','transparent');
			$('#logo').attr('src','img/arm-logo.svg');
			$('.item-container ul').css('color', '#fff');
		}
	});
});