import logo from './BowlLogo2.png';

function Header(props: any) {
  return (
    <header className="row navbar bg-secondary">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <br />
        <p className="text-white">
          Do you have what it takes to be a part of the Big League?
        </p>
        <p className="text-white">
          Connect with one of our bowlers below to find out!
        </p>
      </div>
    </header>
  );
}

export default Header;
