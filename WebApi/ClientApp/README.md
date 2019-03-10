# CARB Template

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

## Local Development

In the project directory, you can run:

`npm start`

Runs the app in the development mode.<br>
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.<br>
You will also see any lint errors in the console.

## Building for ERG’s Server (to be deployed to /caqmv1 directory)

**NOTE:** In the `.env` file, you’ll see the `REACT_APP_PROD_PATH` environment variable is set to `caqmv1`. If we ever re-deploy to another subdirectory on the server, we’ll need to update this envirionent variable’s value.

To create a development build, run:

`npm run build`

This will create a new build of the app in the "build" directory. You’ll need to manually upload the contents of the "build" directory to ERG’s development server in the `/caqmv1` directory.

## Building for ERG’s Server (to be deployed to /aqviewhtm directory)

To create a development build, run:

`npm run build:dev`

_This npm script is written for macOS only, so will likely fail if run from Windows._

This will create a new build of the app in the "dist" directory, timestamped with today’s date (e.g. "dist/2019-01-07"). Because of the way client-side routing is configured, this build will only work when uploaded to a server that has the following directory structure:<br>

https://{{ server root }}/aqviewhtm/{{ timestamped directory }}<br>
For example: https://carbdev.erg.com/aqviewhtm/2019-01-07.

_If the app ever needs to be deployed to another subdirectory, the string "aqviewhtm" needs to be changed in the "dev:env" npm script._

You’ll need to then manually upload the timestamped directory to ERG’s development server in the `/aqviewhtm` directory.

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).
