/* eslint-disable */

(function ($) {
  $(".table-responsive--dynamic .dropdown").on("show.bs.dropdown", function () {
    var $btnDropDown = $(this).find(".btn-link");
    var $listHolder = $(this).find(".table-responsive--dynamic .dropdown-menu");
    //reset position property for DD container
    $(this).css("position", "static");
    $listHolder.css({
      "top": ($btnDropDown.offset().top + $btnDropDown.outerHeight(true)) + "px",
      "left": $btnDropDown.offset().left + "px"
    });
    $listHolder.data("open", true);
  });
  //add BT DD hide event
  $(".table-responsive--dynamic .dropdown").on("hidden.bs.dropdown", function () {
    var $listHolder = $(this).find(".table-responsive--dynamic .dropdown-menu");
    $listHolder.data("open", false);
  });
  //add on scroll for table holder
  $(".table-responsive--dynamic").scroll(function () {
    var $ddHolder = $(this).find(".table-responsive--dynamic .dropdown")
    var $btnDropDown = $(this).find(".btn-link");
    var $listHolder = $(this).find(".table-responsive--dynamic .dropdown-menu");
    if ($listHolder.data("open")) {
      $listHolder.css({
        "top": ($btnDropDown.offset().top + $btnDropDown.outerHeight(true)) + "px",
        "left": $btnDropDown.offset().left + "px"
      });
      $ddHolder.toggleClass("open", ($btnDropDown.offset().left > $(this).offset().left))
    }
  })
  // Preloader
  window.addEventListener('load', function () {
    document.querySelector('body').classList.add("loaded")
  });

  (from = $('input[name="date-range-from"]')
    .datepicker({
      defaultDate: "+1w",
      changeMonth: true,
      numberOfMonths: 2,
      onSelect: function () {
        $("#ui-datepicker-div").addClass("testX");
      },
    })
    .on("change", function () {
      to.datepicker("option", "minDate", getDate(this));
    })),
  (to = $('input[name="date-range-to"]')
    .datepicker({
      defaultDate: "+1w",
      changeMonth: true,
      numberOfMonths: 2,
    })
    .on("change", function () {
      from.datepicker("option", "maxDate", getDate(this));
    }));

  function getDate(element) {
    var date;
    try {
      date = $.datepicker.parseDate(dateFormat, element.value);
    } catch (error) {
      date = null;
    }

    return date;
  }

    /* sidebar collapse  */
    $('body').on("click", function (e) {
        if (window.matchMedia('(max-width: 1151px)').matches) {
            if ($(e.target).is(".sidebar__menu-group *") == false &&
                $(e.target).is('.header-top *') == false) {
                $(".sidebar").addClass("collapsed");
                $(".contents").addClass("expanded");
                $(".footer-wrapper").addClass("expanded");
            }
        }
    });

    const sidebarToggle = document.querySelector(".sidebar-toggle");

    function sidebarCollapse(e) {
        e.preventDefault();
        $('.overlay-dark-sidebar').toggleClass('show');
        document.querySelector(".sidebar").classList.toggle("collapsed");
        document.querySelector(".contents").classList.toggle("expanded");
        document.querySelector(".footer-wrapper").classList.toggle("expanded");
    }
    if (sidebarToggle) {
        sidebarToggle.addEventListener("click", sidebarCollapse);
    }

    $(window).on('scroll', function (e) {
        let blogContainer = document.querySelector(".blog-details"),
            shareGroup = document.querySelector(".blog-share-top");
        if (blogContainer != null && shareGroup != null) {
            window.pageYOffset <= blogContainer.offsetTop ? shareGroup.classList.remove("show") : window.pageYOffset >= blogContainer.offsetTop && window.pageYOffset <= blogContainer.offsetTop + blogContainer.clientHeight - 700 ? shareGroup.classList.add("show") : shareGroup.classList.remove("show");
        }
    });

    /* sidebar nav events */
    $(".sidebar_nav .has-child ul").hide();
    $(".sidebar_nav .has-child.open ul").show();
    $(".sidebar_nav .has-child >a").on("click", function (e) {
        e.preventDefault();
        $(this).parent().next("has-child").slideUp();
        $(this).parent().parent().children(".has-child").children("ul").slideUp();
        $(this).parent().parent().children(".has-child").removeClass("open");
        if ($(this).next().is(":visible")) {
            $(this).parent().removeClass("open");
        } else {
            $(this).parent().addClass("open");
            $(this).next().slideDown();
        }
    });

    /* Header mobile view */
    $(window)
        .bind("resize", function () {
            var screenSize = window.innerWidth;
            if ($(this).width() <= 767.98) {
                $(".navbar-right__menu").appendTo(".mobile-author-actions");
                // $(".search-form").appendTo(".mobile-search");
                $(".contents").addClass("expanded");
                $(".sidebar ").addClass("collapsed");
            } else {
                $(".navbar-right__menu").appendTo(".navbar-right");
            }

        })
        .trigger("resize");
    $(window)
        .bind("resize", function () {
            var screenSize = window.innerWidth;
            if ($(this).width() > 767.98) {
                $(".dm-mail-sidebar").addClass("show");
            }
        })
        .trigger("resize");
    $(window)
        .bind("resize", function () {
            var screenSize = window.innerWidth;
            if ($(this).width() <= 991) {
                $(".sidebar").addClass("collapsed");
                $(".sidebar-toggle").on("click", function () {
                    $(".overlay-dark-sidebar").toggleClass("show");
                });
                $(".overlay-dark-sidebar").on("click", function () {
                    $(this).removeClass("show");
                    $(".sidebar").addClass("collapsed");
                });
            }
        })
        .trigger("resize");

  /* Mobile Menu */
  $(window)
    .bind("resize", function () {
      var screenSize = window.innerWidth;
      if ($(this).width() <= 991.98) {
        $(".menu-horizontal").appendTo(".mobile-nav-wrapper");
      }
    })
    .trigger("resize");

  $(".btn-search").on("click", function () {
    $(this).toggleClass("search-active");
    $(".mobile-search").toggleClass("show");
    $(".mobile-author-actions").removeClass("show");
  });

  $(".kanban-items li").hover(function () {
    $(this).toggleClass("active");
  });

  $(".btn-author-action").on("click", function () {
    $(".mobile-author-actions").toggleClass("show");
    $(".mobile-search").removeClass("show");
    $(".btn-search").removeClass("search-active");
  });

  $(".menu-mob-trigger").on("click", function (e) {
    e.preventDefault();
    $(".mobile-nav-wrapper").toggleClass("show");
  });

  $(".nav-close").on("click", function (e) {
    e.preventDefault();
    $(".mobile-nav-wrapper").removeClass("show");
  });

  $('.list-thumb-gallery li a').click(function (e) {

    $('.list-thumb-gallery li a').removeClass('active');

    var $this = $(this);
    if (!$this.hasClass('active')) {
      $this.addClass('active');
    }
  });

  /* Dropdown Event */
  $(".dropdown-clickEvent a").on("click", function (e) {
    e.preventDefault();
    const text = $(this).text();
    const notice = `
            <div class="dm-notice">
                <span>${text} Clicked</span>
            </div>
        `;
    $(".dm-message").prepend(notice);
    $(".dm-message").toggleClass("show");

    setTimeout(function () {
      $(".dm-message").empty();
      $(".dm-message").removeClass("show");
    }, 3000);
  });

  /* Hover active */
  $(".friends-follow").on("click", function (e) {
    e.preventDefault();
    $button = $(this);
    if ($button.hasClass("following")) {
      //$.ajax(); Do Unfollow

      $button.removeClass("following");
      $button.removeClass("unfollow");
      $button.text("Follow");
    } else {
      // $.ajax(); Do Follow
      $button.html('<i class="la la-check"></i> following');
      $button.addClass("following");
    }
  });

  /* Collapsable Menu */
  function mobileMenu(dropDownTrigger, dropDown) {
    $(".menu-wrapper .menu-collapsable " + dropDown).slideUp();

    $(".menu-wrapper " + dropDownTrigger).on("click", function (e) {
      if ($(this).parent().hasClass("has-submenu")) {
        e.preventDefault();
      }
      $(this)
        .toggleClass("open")
        .siblings(dropDown)
        .slideToggle()
        .parent()
        .siblings(".sub-menu")
        .children(dropDown)
        .slideUp()
        .siblings(dropDownTrigger)
        .removeClass("open");
    });
  }
  mobileMenu(".menu-collapsable .dm-menu__link", ".dm-submenu");

  /* Bookmarks Icon */
  $(".like-icon").click(function () {
    $(this).find(".icon").toggleClass("lar");
    $(this).find(".icon").toggleClass("las");
  });

})(jQuery);