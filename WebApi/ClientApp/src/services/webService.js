// @flow

// import { basepath } from 'routes.js';
// TODO: figure out why basepath is being imported as undefined from routes.js
const {
  REACT_APP_DEV: dev,
  REACT_APP_DEV_PATH: devPath,
  REACT_APP_PROD_PATH: prodPath,
} = process.env;
const basepath = dev ? devPath : prodPath;

// export const apiUrl = 'https://carbdev.erg.com/caqm/api';
export const apiUrl = `${window.location.origin}${basepath}api`;

// return authorization header with jwt token or empty object
function authHeader() {
  const user = JSON.parse(localStorage.getItem('user'));
  if (user && user.token) return { Authorization: 'Bearer ' + user.token };
  return {};
}

function handleResponse(response) {
  return new Promise((resolve, reject) => {
    if (response.ok) {
      // return json if it was returned in the response
      const contentType = response.headers.get('content-type');
      if (contentType && contentType.includes('application/json')) {
        response.json().then((json) => resolve(json));
      } else {
        resolve();
      }
    } else {
      // return error message from response body
      response.text().then((text) => reject(text));
    }
  });
}

function handleError(error) {
  return Promise.reject(error && error.message);
}

export function register(user) {
  const url = `${apiUrl}/users/register`;
  const options = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json', Accept: '*/*' },
    body: JSON.stringify(user),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function login(username, password) {
  const url = `${apiUrl}/users/authenticate`;
  const options = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify({ username, password }),
  };
  return fetch(url, options)
    .then(handleResponse, handleError)
    .then((user) => {
      // login successful if there's a jwt token in the response
      if (user && user.token) {
        localStorage.setItem('user', JSON.stringify(user));
      }
      return user;
    });
}

export function logout() {
  localStorage.removeItem('user');
}

export function getAllUsers() {
  const url = `${apiUrl}/users`;
  const options = {
    method: 'GET',
    headers: authHeader(),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function getUserById(id) {
  const url = `${apiUrl}/users/${id}`;
  const options = {
    method: 'GET',
    headers: authHeader(),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function updateUser(user) {
  const url = `${apiUrl}/users/${user.id}`;
  const options = {
    method: 'PUT',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(user),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function deleteUserById(id) {
  const url = `${apiUrl}/users/${id}`;
  const options = {
    method: 'DELETE',
    headers: authHeader(),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

// TODO: rename...upload what?
export function upload(fileData) {
  const url = `${apiUrl}/upload`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fileData),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function importMeasurement(data) {
  const url = `${apiUrl}/MeasurementData/Import`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(data),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function importMonitor(data) {
  const url = `${apiUrl}/Monitors/Import`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(data),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function addSite(fields) {
  const url = `${apiUrl}/Sites/AddSite`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function addMonitors(fields) {
  const url = `${apiUrl}/Monitors/AddMonitor`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function getUserSites(userId) {
  const url = `${apiUrl}/users/GetUserData/${userId}`;
  const options = {};
  return fetch(url, options).then(handleResponse, handleError);
}

export function relocateSite(fields) {
  const url = `${apiUrl}/Sites/Relocate`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function deactivateSite(fields) {
  const url = `${apiUrl}/Sites/Deactivate`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function relocateMonitor(fields) {
  const url = `${apiUrl}/Monitors/Relocate`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function updateMonitor(fields) {
  const url = `${apiUrl}/Monitors/Update`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function deactivateMonitor(fields) {
  const url = `${apiUrl}/Monitors/Deactivate`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}

export function addMonitor(fields) {
  const url = `${apiUrl}/Monitors/Add`;
  const options = {
    method: 'POST',
    headers: { ...authHeader(), 'Content-Type': 'application/json' },
    body: JSON.stringify(fields),
  };
  return fetch(url, options).then(handleResponse, handleError);
}
