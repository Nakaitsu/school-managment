$(function () {
  let toastElemlist = [].slice.call(document.querySelectorAll('.toast'))
  let toastList = toastElemlist.map(function (toastElem) {
    return new bootstrap.Toast(toastElem, {
      animation: true,
      autohide: false,
      delay: 3000
    })
  })
  
  if(toastList) {
    toastList = makeIterator(toastList)
  
    async function nome() {
      let i = toastList.next()
  
      if(!i.done) {
        await sleep(500)
        i.value.show()
        nome()
      }
    }
  
    nome()
  }
})

const makeIterator = (array) => {
  let nextIndex = 0;

  return {
    next: () => {
      return nextIndex < array.length ?
        { value: array[nextIndex++], done: false } :
        { done: true };
    }
  }
}

function sleep(ms) {
  return new Promise( resolve => setTimeout(resolve, ms) )
}