// Image对象转base64
function imageToBase64(image) {
  const canvas = document.createElement('canvas')
  const width = image.width
  const height = image.height

  canvas.width = width
  canvas.height = height
  const context = canvas.getContext('2d')
  context.drawImage(image, 0, 0, width, height)
  return canvas.toDataURL('image/png')
}

// 回调方式
function urlToBase64(url, callback = null) {
  const image = new Image()

  image.setAttribute('crossOrigin', 'Anonymous')
  image.src = url + '?v=' + Math.random()

  image.onload = function() {
    const dataURL = imageToBase64(image)
    if (callback) {
      callback(dataURL)
    }
  }
}

// Promise方式
export function urlToBase64Async(url) {
  return new Promise((resolve, reject) => {
    urlToBase64(url, (data) => {
      resolve(data)
    })
  })
}
