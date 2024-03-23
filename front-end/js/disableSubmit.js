const form = document.getElementById('registrationForm');
const submitButton = document.querySelector('.btn__submit');

form.addEventListener('input', function() {
    const inputs = form.querySelectorAll('input[required]');
    let allFilled = true;

    inputs.forEach(input => {
        if (!input.value.trim()) {
            allFilled = false;
        }
    });

    if (allFilled) {
        submitButton.disabled = false;
    } else {
        submitButton.disabled = true;
    }
});
