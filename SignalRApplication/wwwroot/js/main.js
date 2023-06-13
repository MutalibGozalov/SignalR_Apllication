(function($) {

	"use strict";

	$('[data-toggle="tooltip"]').tooltip()

})(jQuery);

$('.close').click((e) => {
	let id = $(e.currentTarget).data('id')

	

	fetch(`/people/delete/${id}`, {
		method: 'Delete',
	}).then(response => { alert('success') })
		.catch(error => { alert('failll') })
})