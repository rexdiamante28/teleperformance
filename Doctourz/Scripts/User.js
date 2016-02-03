$(function () {
    $(window).bind("load resize", function () {
        topOffset = 50;
        width = (this.window.innerWidth > 0) ? this.window.innerWidth : this.screen.width;
        if (width < 768) {
            $('div.navbar-collapse').addClass('collapse');
            topOffset = 100; // 2-row-menu
        } else {
            $('div.navbar-collapse').removeClass('collapse');
        }

        height = ((this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height) - 1;
        height = height - topOffset;
        if (height < 1) height = 1;
        if (height > topOffset) {
            $("#page-wrapper").css("min-height", (height) + "px");
        }
    });

    var url = window.location;
    var element = $('ul.nav a').filter(function () {
        return this.href == url || url.href.indexOf(this.href) == 0;
    }).addClass('active').parent().parent().addClass('in').parent();
    if (element.is('li')) {
        element.addClass('active');
    }
});

FoldSideBar = function foldSideBar() {
    document.getElementById('page-wrapper').setAttribute("class", "page-wrapper-close");
    document.getElementById('sidebar').setAttribute("class", "navbar-default sidebar sidebar-close");
    document.getElementById('name-section').setAttribute("class", "name-section top-20 hidden");
}

UnfoldSideBar = function unfoldSideBar() {
    document.getElementById('page-wrapper').setAttribute("class", "page-wrapper-open");
    document.getElementById('sidebar').setAttribute("class", "navbar-default sidebar sidebar-open");
    document.getElementById('name-section').setAttribute("class", "name-section top-20");
}

OpenCover = function openCover() {
    document.getElementById('transparent-cover').setAttribute("class", "transparent-cover-open");
}

CloseCover = function closeCover() {
    document.getElementById('transparent-cover').setAttribute("class", "transparent-cover-close");
}

OpenSidebarChild = function openSidebarChild() {
    document.getElementById('sidebar-child').setAttribute("class", "sidebar-child-open");
}

CloseSidebarChild = function closeSidebarChild() {
    var openSideBar = document.getElementById('currentSidebarChild')
    var oldVal = openSideBar.value;
    if(oldVal!="empty"){
        document.getElementById(oldVal).setAttribute("class", "");
    }

    document.getElementById('sidebar-child').setAttribute("class", "sidebar-child-close");
}

SidebarChildDecide = function sidebarChildDecide(id) {
    var openSideBar = document.getElementById('currentSidebarChild')
    var oldVal = openSideBar.value;
    var newVal = id;

    if(oldVal!="empty"){
        document.getElementById(oldVal).setAttribute("class", "");
        document.getElementById(id).setAttribute("class","bggreen5");
    }
    else {
        document.getElementById(id).setAttribute("class", "bggreen5");
    }

    //if the sidebar child is close, open it together with cover
    //if the sidebar is open and the corresponding link is clicked, close it together with cover
    //if the sidebar is open and a different link is clicked, siebar child must remain open together with cover

    document.getElementById('currentSidebarChild').value = id;

    var sidebarChild = document.getElementById('sidebar-child');
    var sidebarChildClass = sidebarChild.getAttribute("class");
    
    if(sidebarChildClass=="sidebar-child-close"){
        OpenSidebarChild();
        OpenCover();
    }
    else if (sidebarChildClass == "sidebar-child-open"&& oldVal == newVal) {
        CloseSidebarChild();
        CloseCover();
    }
    else if (sidebarChildClass == "sidebar-child-open" && oldVal != newVal) {
    }
}

// telemed user interface functions
ExpandInfo = function expandInfo(){
    document.getElementById('info').setAttribute("class", "info-open");

    document.getElementById('l1').style.display = "";
    document.getElementById('l2').style.display = "none";
    document.getElementById('l3').style.display = "";
    document.getElementById('patient-initial-info').style.display = "";
}
ExpandChat = function expandChat() {
    document.getElementById('chat').setAttribute("class", "chat-open");

    document.getElementById('r1').style.display = "";
    document.getElementById('r2').style.display = "none";
    document.getElementById('r3').style.display = "";
    document.getElementById('messaging-controls').style.display = "";
    document.getElementById('chatbox').style.display = "";
    document.getElementById('message-box').style.display = "";
}

CompressInfo = function compressInfo() {
    document.getElementById('info').setAttribute("class", "info-close");

    document.getElementById('l1').style.display = "none";
    document.getElementById('l2').style.display = "";
    document.getElementById('l3').style.display = "none";
    document.getElementById('patient-initial-info').style.display = "none";

}
CompressChat = function compressChat() {
    document.getElementById('chat').setAttribute("class", "chat-close");

    document.getElementById('r1').style.display = "none";
    document.getElementById('r2').style.display = "";
    document.getElementById('r3').style.display = "none";
    document.getElementById('messaging-controls').style.display = "none";
    document.getElementById('chatbox').style.display = "none";
    document.getElementById('message-box').style.display = "none";
}


TelemedCoverDecide = function telemedCoverDecide(id) {

    var openBottomBar = document.getElementById('currentBottomBar')
    var oldVal = openBottomBar.value;
    var newVal = id;

    if (oldVal != "empty") {
        document.getElementById(oldVal).setAttribute("class", "bottom-link");
        document.getElementById(id).setAttribute("class", "bottom-link-active");
    }
    else {
        document.getElementById(id).setAttribute("class", "bottom-link-active");
    }

    //if the sidebar child is close, open it together with cover
    //if the sidebar is open and the corresponding link is clicked, close it together with cover
    //if the sidebar is open and a different link is clicked, siebar child must remain open together with cover

    document.getElementById('currentBottomBar').value = id;

    var telemedCover = document.getElementById('telemedCover');
    var telemedCoverClass = telemedCover.getAttribute("class");
    var bottomDock = document.getElementById('bottom-dock');



    if (telemedCoverClass == "hidden") {
        telemedCover.setAttribute("class", "");
        bottomDock.setAttribute("class", "bottom-dock-open");
    }
    else if (telemedCoverClass == "" && oldVal == newVal) {
        telemedCover.setAttribute("class", "hidden");
        document.getElementById(id).setAttribute("class", "bottom-link");
        bottomDock.setAttribute("class", "bottom-dock-close");
    }
    else if (telemedCoverClass == "" && oldVal != newVal) {
    }

}

TeleDecide = function telemedCoverDecide() {


    var bottomDock = document.getElementById('bottom-dock');
    var bottomClass = document.getElementById('bottom-dock').getAttribute("class");


    if (bottomClass == "bottom-dock-close relative") {
        bottomDock.setAttribute("class", "bottom-dock-open relative");
    }
    else if (bottomClass == "bottom-dock-open relative") {
        bottomDock.setAttribute("class", "bottom-dock-close relative");
    }

}
// this is for the slider
/* =========================================================
 * bootstrap-slider.js v2.0.0
 * http://www.eyecon.ro/bootstrap-slider
 * =========================================================
 * Copyright 2012 Stefan Petre
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * ========================================================= */

!function ($) {

    var Slider = function (element, options) {
        this.element = $(element);
        this.picker = $('<div class="slider">' +
							'<div class="slider-track">' +
								'<div class="slider-selection"></div>' +
								'<div class="slider-handle"></div>' +
								'<div class="slider-handle"></div>' +
							'</div>' +
							'<div class="tooltip"><div class="tooltip-arrow"></div><div class="tooltip-inner"></div></div>' +
						'</div>')
							.insertBefore(this.element)
							.append(this.element);
        this.id = this.element.data('slider-id') || options.id;
        if (this.id) {
            this.picker[0].id = this.id;
        }

        if (typeof Modernizr !== 'undefined' && Modernizr.touch) {
            this.touchCapable = true;
        }

        var tooltip = this.element.data('slider-tooltip') || options.tooltip;

        this.tooltip = this.picker.find('.tooltip');
        this.tooltipInner = this.tooltip.find('div.tooltip-inner');

        this.orientation = this.element.data('slider-orientation') || options.orientation;
        switch (this.orientation) {
            case 'vertical':
                this.picker.addClass('slider-vertical');
                this.stylePos = 'top';
                this.mousePos = 'pageY';
                this.sizePos = 'offsetHeight';
                this.tooltip.addClass('right')[0].style.left = '100%';
                break;
            default:
                this.picker
					.addClass('slider-horizontal')
					.css('width', this.element.outerWidth());
                this.orientation = 'horizontal';
                this.stylePos = 'left';
                this.mousePos = 'pageX';
                this.sizePos = 'offsetWidth';
                this.tooltip.addClass('top')[0].style.top = -this.tooltip.outerHeight() - 14 + 'px';
                break;
        }

        this.min = this.element.data('slider-min') || options.min;
        this.max = this.element.data('slider-max') || options.max;
        this.step = this.element.data('slider-step') || options.step;
        this.value = this.element.data('slider-value') || options.value;
        if (this.value[1]) {
            this.range = true;
        }

        this.selection = this.element.data('slider-selection') || options.selection;
        this.selectionEl = this.picker.find('.slider-selection');
        if (this.selection === 'none') {
            this.selectionEl.addClass('hide');
        }
        this.selectionElStyle = this.selectionEl[0].style;


        this.handle1 = this.picker.find('.slider-handle:first');
        this.handle1Stype = this.handle1[0].style;
        this.handle2 = this.picker.find('.slider-handle:last');
        this.handle2Stype = this.handle2[0].style;

        var handle = this.element.data('slider-handle') || options.handle;
        switch (handle) {
            case 'round':
                this.handle1.addClass('round');
                this.handle2.addClass('round');
                break
            case 'triangle':
                this.handle1.addClass('triangle');
                this.handle2.addClass('triangle');
                break
        }

        if (this.range) {
            this.value[0] = Math.max(this.min, Math.min(this.max, this.value[0]));
            this.value[1] = Math.max(this.min, Math.min(this.max, this.value[1]));
        } else {
            this.value = [Math.max(this.min, Math.min(this.max, this.value))];
            this.handle2.addClass('hide');
            if (this.selection == 'after') {
                this.value[1] = this.max;
            } else {
                this.value[1] = this.min;
            }
        }
        this.diff = this.max - this.min;
        this.percentage = [
			(this.value[0] - this.min) * 100 / this.diff,
			(this.value[1] - this.min) * 100 / this.diff,
			this.step * 100 / this.diff
        ];

        this.offset = this.picker.offset();
        this.size = this.picker[0][this.sizePos];

        this.formater = options.formater;

        this.layout();

        if (this.touchCapable) {
            // Touch: Bind touch events:
            this.picker.on({
                touchstart: $.proxy(this.mousedown, this)
            });
        } else {
            this.picker.on({
                mousedown: $.proxy(this.mousedown, this)
            });
        }

        if (tooltip === 'show') {
            this.picker.on({
                mouseenter: $.proxy(this.showTooltip, this),
                mouseleave: $.proxy(this.hideTooltip, this)
            });
        } else {
            this.tooltip.addClass('hide');
        }
    };

    Slider.prototype = {
        constructor: Slider,

        over: false,
        inDrag: false,

        showTooltip: function () {
            this.tooltip.addClass('in');
            //var left = Math.round(this.percent*this.width);
            //this.tooltip.css('left', left - this.tooltip.outerWidth()/2);
            this.over = true;
        },

        hideTooltip: function () {
            if (this.inDrag === false) {
                this.tooltip.removeClass('in');
            }
            this.over = false;
        },

        layout: function () {
            this.handle1Stype[this.stylePos] = this.percentage[0] + '%';
            this.handle2Stype[this.stylePos] = this.percentage[1] + '%';
            if (this.orientation == 'vertical') {
                this.selectionElStyle.top = Math.min(this.percentage[0], this.percentage[1]) + '%';
                this.selectionElStyle.height = Math.abs(this.percentage[0] - this.percentage[1]) + '%';
            } else {
                this.selectionElStyle.left = Math.min(this.percentage[0], this.percentage[1]) + '%';
                this.selectionElStyle.width = Math.abs(this.percentage[0] - this.percentage[1]) + '%';
            }
            if (this.range) {
                this.tooltipInner.text(
					this.formater(this.value[0]) +
					' : ' +
					this.formater(this.value[1])
				);
                this.tooltip[0].style[this.stylePos] = this.size * (this.percentage[0] + (this.percentage[1] - this.percentage[0]) / 2) / 100 - (this.orientation === 'vertical' ? this.tooltip.outerHeight() / 2 : this.tooltip.outerWidth() / 2) + 'px';
            } else {
                this.tooltipInner.text(
					this.formater(this.value[0])
				);
                this.tooltip[0].style[this.stylePos] = this.size * this.percentage[0] / 100 - (this.orientation === 'vertical' ? this.tooltip.outerHeight() / 2 : this.tooltip.outerWidth() / 2) + 'px';
            }
        },

        mousedown: function (ev) {

            // Touch: Get the original event:
            if (this.touchCapable && ev.type === 'touchstart') {
                ev = ev.originalEvent;
            }

            this.offset = this.picker.offset();
            this.size = this.picker[0][this.sizePos];

            var percentage = this.getPercentage(ev);

            if (this.range) {
                var diff1 = Math.abs(this.percentage[0] - percentage);
                var diff2 = Math.abs(this.percentage[1] - percentage);
                this.dragged = (diff1 < diff2) ? 0 : 1;
            } else {
                this.dragged = 0;
            }

            this.percentage[this.dragged] = percentage;
            this.layout();

            if (this.touchCapable) {
                // Touch: Bind touch events:
                $(document).on({
                    touchmove: $.proxy(this.mousemove, this),
                    touchend: $.proxy(this.mouseup, this)
                });
            } else {
                $(document).on({
                    mousemove: $.proxy(this.mousemove, this),
                    mouseup: $.proxy(this.mouseup, this)
                });
            }

            this.inDrag = true;
            var val = this.calculateValue();
            this.element.trigger({
                type: 'slideStart',
                value: val
            }).trigger({
                type: 'slide',
                value: val
            });
            return false;
        },

        mousemove: function (ev) {

            // Touch: Get the original event:
            if (this.touchCapable && ev.type === 'touchmove') {
                ev = ev.originalEvent;
            }

            var percentage = this.getPercentage(ev);
            if (this.range) {
                if (this.dragged === 0 && this.percentage[1] < percentage) {
                    this.percentage[0] = this.percentage[1];
                    this.dragged = 1;
                } else if (this.dragged === 1 && this.percentage[0] > percentage) {
                    this.percentage[1] = this.percentage[0];
                    this.dragged = 0;
                }
            }
            this.percentage[this.dragged] = percentage;
            this.layout();
            var val = this.calculateValue();
            this.element
				.trigger({
				    type: 'slide',
				    value: val
				})
				.data('value', val)
				.prop('value', val);
            return false;
        },

        mouseup: function (ev) {
            if (this.touchCapable) {
                // Touch: Bind touch events:
                $(document).off({
                    touchmove: this.mousemove,
                    touchend: this.mouseup
                });
            } else {
                $(document).off({
                    mousemove: this.mousemove,
                    mouseup: this.mouseup
                });
            }

            this.inDrag = false;
            if (this.over == false) {
                this.hideTooltip();
            }
            this.element;
            var val = this.calculateValue();
            this.element
				.trigger({
				    type: 'slideStop',
				    value: val
				})
				.data('value', val)
				.prop('value', val);
            return false;
        },

        calculateValue: function () {
            var val;
            if (this.range) {
                val = [
					(this.min + Math.round((this.diff * this.percentage[0] / 100) / this.step) * this.step),
					(this.min + Math.round((this.diff * this.percentage[1] / 100) / this.step) * this.step)
                ];
                this.value = val;
            } else {
                val = (this.min + Math.round((this.diff * this.percentage[0] / 100) / this.step) * this.step);
                this.value = [val, this.value[1]];
            }
            return val;
        },

        getPercentage: function (ev) {
            if (this.touchCapable) {
                ev = ev.touches[0];
            }
            var percentage = (ev[this.mousePos] - this.offset[this.stylePos]) * 100 / this.size;
            percentage = Math.round(percentage / this.percentage[2]) * this.percentage[2];
            return Math.max(0, Math.min(100, percentage));
        },

        getValue: function () {
            if (this.range) {
                return this.value;
            }
            return this.value[0];
        },

        setValue: function (val) {
            this.value = val;

            if (this.range) {
                this.value[0] = Math.max(this.min, Math.min(this.max, this.value[0]));
                this.value[1] = Math.max(this.min, Math.min(this.max, this.value[1]));
            } else {
                this.value = [Math.max(this.min, Math.min(this.max, this.value))];
                this.handle2.addClass('hide');
                if (this.selection == 'after') {
                    this.value[1] = this.max;
                } else {
                    this.value[1] = this.min;
                }
            }
            this.diff = this.max - this.min;
            this.percentage = [
				(this.value[0] - this.min) * 100 / this.diff,
				(this.value[1] - this.min) * 100 / this.diff,
				this.step * 100 / this.diff
            ];
            this.layout();
        }
    };

    $.fn.slider = function (option, val) {
        return this.each(function () {
            var $this = $(this),
				data = $this.data('slider'),
				options = typeof option === 'object' && option;
            if (!data) {
                $this.data('slider', (data = new Slider(this, $.extend({}, $.fn.slider.defaults, options))));
            }
            if (typeof option == 'string') {
                data[option](val);
            }
        })
    };

    $.fn.slider.defaults = {
        min: 0,
        max: 10,
        step: 1,
        orientation: 'horizontal',
        value: 5,
        selection: 'before',
        tooltip: 'show',
        handle: 'round',
        formater: function (value) {
            return value;
        }
    };

    $.fn.slider.Constructor = Slider;

}(window.jQuery);



//this is for the slider



// telemed user interface functions


//function for toggling element's display
ToggleElement = function toggleElement(id) {
    var concatId = '#' + id;
    $(concatId).toggle('fast','linear');
}
//function for toggling element's display

toggleElement = function toggleelement(id) {
    var finalId = '#' + id;
    $(finalId).toggle("fast", "linear");
}


loadPage = function loadPage(action) {
        $.post("/User/" + action, function (data) {
            $(".sidebar-body").html(data);
        });
}

loadPageBottom = function loadPageBottom(action) {
    $.post("/User/" + action, function (data) {
        $("#bottom-container").html(data);
    });
}

loadPartialView = function loadPartialView(action,urlSegment,target) {
    $.post(urlSegment + action, function (data) {
        $(target).html(data);
    });
}
HideElement = function hideElement(id) {
    var concatId = '#' + id;
    $(concatId).hide();
}

ShowElement = function showElement(id) {
    var concatId = '#' + id;
    $(concatId).show();
}

TestAlert = function testAlert(message) {
    alert(message);
}

