document.addEventListener('DOMContentLoaded', function(e){ 
    var elements = $('.modal-overlay, .modal');
    var ScrollLock = $('body')

    $('.obl').click(function(){
        elements.addClass('active');
        ScrollLock.addClass('scroll_lock')
    });

    $('.close-modal').click(function(){
        elements.removeClass('active');
        ScrollLock.removeClass('scroll_lock')
    });
}); 