(function() {
  const navbar = document.querySelector('.navbar')
  const body = document.querySelector('body')
  const contactUs = document.querySelector('.contactUs')

  window.addEventListener('scroll', (e) => {
    if(body.getBoundingClientRect().top === 0) {
      navbar.classList.add('navbar-alpha')
      navbar.classList.remove('fixed-top')
      navbar.dataset.position = 'absolute'

      contactUs.classList.add('btn-primary')
      contactUs.classList.remove('text-white')
    } else {
      navbar.classList.remove('navbar-alpha')
      navbar.classList.add('fixed-top')
      navbar.dataset.position = 'fixed'

      contactUs.classList.remove('btn-primary')
      contactUs.classList.add('text-white')
    }

  })
})()