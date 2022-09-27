
$(function(){

    let v = false;

    let $fish, $meat;

    $('button#vegOn').click(function() { 

        if(v === false)
        {
            $fish = $(".fish").parent().parent().detach();

            $('.meat').after("<li class='tofu'><em>Tofu</em></li>");
            $meat = $('.meat').detach();

            $('.hamburger').replaceWith('<li class="portobello"><em>Portobello Mushroom</em></li>');

            $('.portobello').parent().parent().addClass('veg_leaf');
            $('.tofu').parent().parent().addClass('veg_leaf');


            v = true;
        }

    });

    $('#restoreMe').click(function() { 

        if(v === true)
        {
            $('.menu_entrees li').first().before($fish);

            $('.tofu').each(function(i){ 
                $(this).after($meat[i]);
            } );

            $('.tofu').parent().parent().removeClass('veg_leaf');
            $('.tofu').remove();

            $('.portobello').parent().parent().removeClass('veg_leaf');
            $('.portobello').replaceWith('<li class="hamburger">Hamburger</li>');


            v = false;
        }

    });

});